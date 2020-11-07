using Foundation;
using System;
using UIKit;

namespace Tink.iOS.Demo
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // test Tink
            // TestTink();
            TestDeterTink();
        }

        private void TestDeterTink()
        {
            NSError error;
            RegisterAead();

            var handleStore = new TINKKeysetHandle("name", out error);


            // aead deter
            var tpl = new TINKDeterministicAeadKeyTemplate(TINKDeterministicAeadKeyTemplates.TINKAes256Siv, out error);
            var handle = new TINKKeysetHandle(tpl, out error);
            ITINKDeterministicAead aeadDeter = TINKDeterministicAeadFactory.PrimitiveWithKeysetHandle(handle, out error);
            if (error != null)
            {
                Console.WriteLine("Error: " + error.LocalizedFailureReason);
                return;
            }

            // encrypt
            string[] items = new string[]
            {
                "key_long_1",
                "key_email",
            };
            for (int i = 0; i < 2; i++)
            {
                foreach (var item in items)
                {
                    // encrypt
                    string associatedData = "name_default";
                    NSData cipher = aeadDeter.EncryptDeterministically(NSData.FromString(item, NSStringEncoding.UTF8), NSData.FromString(associatedData, NSStringEncoding.UTF8), out error);
                    if (error != null)
                    {
                        Console.WriteLine(error.LocalizedFailureReason);
                        return;
                    }

                    Console.WriteLine(cipher.GetBase64EncodedString(NSDataBase64EncodingOptions.None));

                    // decrypt
                    NSData unencryped = aeadDeter.DecryptDeterministically(cipher, NSData.FromString(associatedData, NSStringEncoding.UTF8), out error);
                    if (error != null)
                    {
                        Console.WriteLine(error.LocalizedFailureReason);
                        return;
                    }
                    Console.WriteLine(unencryped.ToString(NSStringEncoding.UTF8));
                }
            }
        }

        private void TestTink()
        {
            RegisterAead();

            // gen key
            NSError error;
            var tpl = new TINKAeadKeyTemplate(TINKAeadKeyTemplates.Aes256Gcm, out error);
            if (error != null)
            {
                Console.WriteLine("Error: " + error);
                return;
            }
            var handle = new TINKKeysetHandle(tpl, out error);
            if (error != null)
            {
                Console.WriteLine("Error: " + error);
                return;
            }

            // store
            var keysetName = "co.tnn.tink.demo_key";
            if (!handle.WriteToKeychainWithName(keysetName, true, out error))
            {
                Console.WriteLine("Error: " + error);
                return;
            }

            // load
            TINKKeysetHandle handleStore = new TINKKeysetHandle(keysetName, out error);
            if (error != null)
            {
                Console.WriteLine("Error: " + error);
                return;
            }

            // AEAD
            ITINKAead aead = TINKAeadFactory.PrimitiveWithKeysetHandle(handleStore, out error);
            if (error != null)
            {
                Console.WriteLine("Error: " + error);
                return;
            }

            // encrypt
            NSData cipher = aead.Encrypt(NSData.FromString("hello world", NSStringEncoding.UTF8), NSData.FromString("k_value", NSStringEncoding.UTF8), out error);
            if (error != null)
            {
                Console.WriteLine("Error: " + error);
                return;
            }

            Console.WriteLine(cipher.GetBase64EncodedString(NSDataBase64EncodingOptions.None));

            // decrypt
            var plain = aead.Decrypt(cipher, NSData.FromString("k_value", NSStringEncoding.UTF8), out error);
            if (error != null)
            {
                Console.WriteLine("Error: " + error);
                return;
            }
            Console.WriteLine(plain.ToString(NSStringEncoding.UTF8));
        }

        private void RegisterAead()
        {
            Console.WriteLine(Constants.TINKVersion);
            var config = new TINKAeadConfig(out NSError error);
            if (error != null)
            {
                Console.WriteLine("Error: " + error);
                return;
            }

            TINKConfig.RegisterConfig(config, out error);
            if (error != null)
            {
                Console.WriteLine("Error: " + error);
                return;
            }
        }
    }
}