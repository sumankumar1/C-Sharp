using LibraryData;
using LibraryData.EntityModels;
using LibraryDatabase;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryServices
{
    public class LibraryAssetService : ILibraryAsset
    {
        private LibraryContext _context;

        public LibraryAssetService(LibraryContext context)
        {
            _context = context;
        }
        public void Add(LibraryAsset newAsset)
        {
            _context.Add(newAsset);
            _context.SaveChanges();
        }

        public IEnumerable<LibraryAsset> GetAll()
        {
            return _context.LibraryAssets
                .Include(asset => asset.status)
                .Include(asset => asset.Location);
        }

        public LibraryAsset GetByID(int id)
        {
            return _context.LibraryAssets              
                .Include(asset => asset.status)
                .Include(asset => asset.Location)
                .FirstOrDefault(asset => asset.Id == id);
        }

        public LibraryBranch GetCurrentLocation(int id)
        {
            return _context.LibraryAssets
                .FirstOrDefault(asset => asset.Id == id)
                .Location;
        }

        public string GetDeweyIndex(int id)
        {
            if(_context.Books.Any(book => book.Id == id))
            {
                return _context.Books
                    .FirstOrDefault(book => book.Id == id)
                    .DeweyIndex;
            }
            else
            {
                return null;
            }
        }

        public string GetIsbn(int id)
        {
            if (_context.Books.Any(book => book.Id == id))
            {
                return _context.Books
                    .FirstOrDefault(book => book.Id == id)
                    .ISBN;
            }
            else
            {
                return null;
            }
        }

        public string GetTitle(int id)
        {
            return _context.LibraryAssets
                .FirstOrDefault(asset => asset.Id == id)
                .Title;
        }

        public string GetType(int id)
        {
            var book = _context.LibraryAssets.OfType<Book>()
                .Where(asset => asset.Id == id);

            return book.Any() ? "Book" : "Video";
        }

        public string GetAuthorOrDirector(int id)
        {
            var isBook = _context.LibraryAssets.OfType<Book>().Where(asset => asset.Id == id).Any();
            var isVideo = _context.LibraryAssets.OfType<Video>().Where(asset => asset.Id == id).Any();

            return isBook ?
                _context.Books.FirstOrDefault(asset => asset.Id == id).Author :
                _context.Videos.FirstOrDefault(asset => asset.Id == id).Director ??
                "Unknown";
        }
    }
}
