using System;
using System.Collections.Generic;
using System.Linq;
using ICT13580067FinalA.Models;
using SQLite;

namespace ICT13580067FinalA.Helpers
{
    public class DbHelper
    {
        SQLiteConnection db;

        public DbHelper(string dbPath)
        {
            db = new SQLiteConnection(dbPath);
            db.CreateTable<Profile>();
        }

        public int AddProfile(Profile profile)
        {
            db.Insert(profile);
            return profile.Id;
        }

        public List<Profile> GetProfile()
        {
            return db.Table<Profile>().ToList();
        }

        public int UpdateProfile(Profile profile)
        {
            return db.Update(profile);
        }

        public int DeleteProfile(Profile profile)
        {
            return db.Delete(profile);
        }
    }
}