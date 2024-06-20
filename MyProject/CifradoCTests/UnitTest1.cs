using Xunit;
using CifradoC;

namespace CifradoCTests
{
    public class CipherTests
    {
        [Fact]
        public void Encrypt_ShouldEncryptText()
        {
            var result = Cipher.Encrypt("hello", 3);
            Assert.Equal("khoor", result);
        }

        [Fact]
        public void Decrypt_ShouldDecryptText()
        {
            var result = Cipher.Decrypt("khoor", 3);
            Assert.Equal("hello", result);
        }

        [Fact]
        public void Encrypt_ShouldEncryptNumbers()
        {
            var result = Cipher.Encrypt("123", 3);
            Assert.Equal("456", result);
        }

        [Fact]
        public void Decrypt_ShouldDecryptNumbers()
        {
            var result = Cipher.Decrypt("456", 3);
            Assert.Equal("123", result);
        }

        [Fact]
        public void Encrypt_ShouldEncryptNumbers2()
        {
            var result = Cipher.Encrypt("hello123", 3);
            Assert.Equal("khoor456", result);
        }

    }
}