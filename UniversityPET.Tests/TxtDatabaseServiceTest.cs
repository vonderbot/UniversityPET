using Moq;
using Xunit;

namespace UniversityPET.Tests
{
    public class TxtDatabaseServiceTest
    {
        [Fact]
        public void ReturningTypeIsUniversity()
        {
            // Arrange
            const string buffer = "{\"Name\":\"NURE\",\"GraduatingPrice\":22000.5,\"Groups\":[{\"Name\":\"ITM - 19 - 2\"," +
                                  "\"Faculty\":\"CS\",\"Mentor\":{\"Salary\":830.0,\"Name\":\"Maria\",\"Sex\":\"M\",\"Age\":55}," +
                                  "\"Students\":[{\"Grade\":83,\"Name\":\"Oleg\",\"Sex\":\"M\",\"Age\":20},{\"Grade\":60,\"Name\":" +
                                  "\"Olegovna\",\"Sex\":\"F\",\"Age\":30},{\"Grade\":35,\"Name\":\"Olegovich\",\"Sex\":\"M\",\"Age\":40}" +
                                  ",{\"Grade\":100,\"Name\":\"Olegasse\",\"Sex\":\"M\",\"Age\":50}]},{\"Name\":\"ITM - 19 - 1\",\"Faculty" +
                                  "\":\"CS\",\"Mentor\":{\"Salary\":450.0,\"Name\":\"Grisha\",\"Sex\":\"F\",\"Age\":0},\"Students\"" +
                                  ":[{\"Grade\":60,\"Name\":\"Slavic\",\"Sex\":\"D\",\"Age\":2000},{\"Grade\":72,\"Name\":\"Aliva\"" +
                                  ",\"Sex\":\"M\",\"Age\":22},{\"Grade\":100,\"Name\":\"Avila\",\"Sex\":\"F\",\"Age\":35},{\"Grade\"" +
                                  ":100,\"Name\":\"Nuruto\",\"Sex\":\"M\",\"Age\":50}]}]}";
            var writer = new Mock<IWriter>();
            var reader = new Mock<IReader>();
            var serializator = new Mock<ISerializator<University>>();
            writer.Setup(repo => repo.Write(buffer));
            reader.Setup(repo => repo.Read()).Returns(buffer);
            serializator.Setup(repo => repo.Serialize(NureUniversityInitializer.Create())).Returns(buffer);
            serializator.Setup(repo => repo.Deserialize(buffer)).Returns(NureUniversityInitializer.Create());
            var databaseService = new TxtDatabaseService<University>(writer.Object, reader.Object, serializator.Object);

            // Act
            var result = databaseService.Read();

            // Assert
            var viewResult = Assert.IsType<University>(result);
        }
    }
}