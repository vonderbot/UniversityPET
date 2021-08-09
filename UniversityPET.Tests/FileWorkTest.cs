using Xunit;

namespace UniversityPET.Tests
{
    public class FileWorkTest
    {
        [Fact]
        public void FileNotEmpty()
        {
            // Arrange
            var path = @"D:\GitHub\NURE.txt";
            var serializator = new Serializator<University>();
            var reader = new FileReader(path);
            var writer = new FileWriter(path);
            var databaseService = new TxtDatabaseService<University>(writer, reader, serializator);

            // Act
            var result = databaseService.Read();

            // Assert
            Assert.NotNull(result);
        }
    }
}