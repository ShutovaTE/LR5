using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LR4;

namespace LR4
{
    public class ArtGallery
    {
        private List<string> artworks = new List<string>();

        public int ArtworkCount => artworks.Count;

        public void AddArtwork(string artwork)
        {
            if (!artworks.Contains(artwork))
            {
                artworks.Add(artwork);
            }
        }

        public void RemoveArtwork(string artwork)
        {
            artworks.Remove(artwork);
        }

        public bool FindArtwork(string artwork)
        {
            return artworks.Contains(artwork);
        }

    }
}
