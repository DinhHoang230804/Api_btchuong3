﻿using Btchuong3.Model.Domain;
using Microsoft.EntityFrameworkCore;

namespace Btchuong3.Data
{
    public class DbInitializer
    {
        private readonly ModelBuilder _builder;

        public DbInitializer(ModelBuilder builder)
        {
            _builder = builder;
        }

        public void Seed()
        {
            _builder.Entity<Author>(a =>
            {
                a.HasData(new Author
                {
                    Id = 1,
                    FullName = "J.K. Rowling",
                });
                a.HasData(new Author
                {
                    Id = 2,
                    FullName = "Fujiko Fujio",
                });
            });

            _builder.Entity<Books>(b =>
            {
                b.HasData(new Books
                {
                    Id = 1,
                    Title = "Harry Potter and the Chamber of Secrets",
                    Description = "Ever since Harry Potter had come home for the summer, the Dursleys had been so mean and hideous that all Harry wanted was to get back to the Hogwarts School for Witchcraft and Wizardry.",
                    IsRead = true,
                    DateRead = DateTime.Now,
                    Rate = 5,
                    Genre = "dung",
                    CoverUrl = "https://images.example.com/BookHarry-Potter.jpg",
                    DateAdded = DateTime.Now,
                    PublisherID=1,
                });

                b.HasData(new Books
                {
                    Id = 2,
                    Title = "Doraemon",
                    Description = "Doraemon phieu luu cung nhung nguoi ban",
                    IsRead = true,
                    DateRead = DateTime.Now,
                    Rate = 5,
                    Genre = "dung",
                    CoverUrl = "https://images.example.com/BookDoraemon.jpg",
                    DateAdded = DateTime.Now,
                    PublisherID = 2,
                });
            });


            _builder.Entity<Publishers>(c =>
            {
                c.HasData(new Publishers
                {
                    Id = 1,
                    Name = "Bloomsbury Publishing",
                });
                c.HasData(new Publishers
                {
                    Id = 2,
                    Name = "Kim dong",
                });
            });

        }

    }
}
