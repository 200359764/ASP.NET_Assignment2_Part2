using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using High_M_Music_Records.Controllers;
using High_M_Music_Records.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SeunghwanKim_ASP.NET_Assignment2_Part1.Models;

namespace SeunghwanKim_ASP.NET_Assignment2_Part1.Tests.Controllers
{
    [TestClass]
    public class ArtistsAlbumsControllerTest
    {
        ArtistsAlbumsController controller;
        Mock<IArtistsAlbumsMock> mock;
        List<artistsAlbums> ArtistsAlbums;

        [TestInitialize]
        public void TestInitalize()
        {

            mock = new Mock<IArtistsAlbumsMock>();

            ArtistsAlbums = new List<artistsAlbums>
            {
                new artistsAlbums { Title = "Samurai", Artist_name = new artistsAlbums {
                Artist_name = "Lilset", Year_of_Release = 2016
                    }
                },
                new artistsAlbums { Title = "YSL", Artist_name = new artistsAlbums {
                Artist_name = "Witry", Year_of_Release = 2017
                    }
                },
                new artistsAlbums { Title = "Last Conscious", Artist_name = new artistsAlbums {
                Artist_name = "A.Lack", Year_of_Release = 2018
                    }
                }
            };



            mock.Setup(m => m.ArtistsAlbums).Returns(ArtistsAlbums.AsQueryable());
            controller = new ArtistsAlbumsController(mock.Object);

        }

        [TestMethod]
        public void IndexLoadsView()
        {
            //arrange
            //ArtistsAlbumsController controller = new ArtistsAlbumsController();

            //act
            ViewResult result = controller.Index() as ViewResult;

            //assert
            Assert.AreEqual("Index", result.ViewName);
        }

        [TestMethod]

        public void IndexReturnsArtistsAlbums()
        {
            var result = (List<artistsAlbums>)((ViewResult)controller.Index()).Model;

            CollectionAssert.AreEqual(ArtistsAlbums, result);
        }
    }
}
