using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Structural.DecoratorPattern;
using Xunit;

namespace DesignPatterns.Test.Structural.Tests.DecoratorPatternTests
{
    public class DecoratorTests
    {
        public IDataSource db = new FileDataSource();
        [Fact]
        public void testFileDataBase()
        {
            // Arrange

            // Act
            db.write("data");
            string data = db.read();
            // Assert
            Assert.Matches("Base", data);
        }

        [Fact]
        public void testEncrypt()
        {
            // Arrange
            IDataSource encrypt = new EncryptDataSource(db);
            // Act
            encrypt.write("data");
            string data = encrypt.read();
            // Assert
            Assert.Matches("Base - decrypted ", data);
        }

        [Fact]
        public void testCompress()
        {
            // Arrange
            IDataSource compress = new CompressDataSource(db);

            // Act
            compress.write("data");
            string data = compress.read();
            // Assert
            Assert.Matches("Base - Decompressed ", data);
        }

        [Fact]
        public void testEncryptCompress()
        {
            // Arrange
            IDataSource encrypt = new EncryptDataSource(db);
            IDataSource compress = new CompressDataSource(encrypt);
            // Act
            compress.write("data");
            string data = compress.read();
            // Assert
            Assert.Matches("Base - decrypted  - Decompressed ", data);
        }

        [Fact]
        public void testCompressEncrypt()
        {
            // Arrange
            IDataSource compress = new CompressDataSource(db);
            IDataSource encrypt = new EncryptDataSource(compress);
            // Act
            encrypt.write("data");
            string data = encrypt.read();
            // Assert
            Assert.Matches("Base - Decompressed  - decrypted ", data);
        }
    }
}
