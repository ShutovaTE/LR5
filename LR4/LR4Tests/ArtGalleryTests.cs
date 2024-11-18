using NUnit.Framework;
using LR4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LR4Tests;

namespace LR4Tests 
{ 
    [TestFixture]
    public class ArtGalleryTests
    {
        [Test]
        public void AddArtwork_ShouldIncreaseArtworkCount()
        {
            var gallery = new ArtGallery();
            gallery.AddArtwork("Mona Lisa");

            Assert.AreEqual(1, gallery.ArtworkCount);
        }

        [Test]
        public void AddArtwork_ShouldNotAllowDuplicateArtworks()
        {
            var gallery = new ArtGallery();
            gallery.AddArtwork("Mona Lisa");
            gallery.AddArtwork("Mona Lisa");

            Assert.AreEqual(1, gallery.ArtworkCount);
        }

        [Test]
        public void RemoveArtwork_ShouldDecreaseArtworkCount()
        {
            var gallery = new ArtGallery();
            gallery.AddArtwork("Mona Lisa");
            gallery.RemoveArtwork("Mona Lisa");

            Assert.AreEqual(0, gallery.ArtworkCount);
        }

        [Test]
        public void FindArtwork_ShouldReturnTrueIfExists()
        {
            var gallery = new ArtGallery();
            gallery.AddArtwork("Mona Lisa");

            Assert.IsTrue(gallery.FindArtwork("Mona Lisa"));
        }

        [Test]
        public void ArtworkCount_ShouldBeZeroWhenGalleryIsEmpty()
        {
            var gallery = new ArtGallery();

            Assert.AreEqual(0, gallery.ArtworkCount);
        }

    }
}