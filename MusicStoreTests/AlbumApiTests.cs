using System;
using System.Net;
using System.Web.Http.Results;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicStore.Controllers.API;
using MusicStore.Models;
using MusicStoreTests.Fakes;

namespace MusicStoreTests
{
    [TestClass]
    public class AlbumApiTests
    {
        [TestMethod]
        public void TestGetAlbumById()
        {
            //Arranging
            FakeAlbumBL fake = new FakeAlbumBL();
            AlbumsController controller = new AlbumsController(fake);
            int id = 1;

            //Act
            var result = controller.GetAlbum(id) as OkNegotiatedContentResult<Album>;


            //Assert
            Assert.AreEqual(id, result.Content.AlbumId);
            Assert.AreEqual("album 1", result.Content.Title);

        }

        [TestMethod]
        public void TestUpdateAlbum()
        {
            //Arrange
            FakeAlbumBL fake = new FakeAlbumBL();
            AlbumsController controller = new AlbumsController(fake);
            int id = 1;
            Album a = new Album()
            {
                AlbumId = 1,
                Title = "Test2"
            };

            //Act
            var result = controller.PutAlbum(id, a) as StatusCodeResult;


            //Assert
            Assert.AreEqual(result.StatusCode, HttpStatusCode.NoContent);
            Assert.AreEqual(id, fake.id);
            Assert.AreEqual(fake.a.Title, a.Title);
        }
    }
}
