﻿using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface ICountryRepository
    {
        ICollection<Country> GetCountries();
        Country GetCountry(int id);
        Country GetCountryByOwner(int OwnerId);
        ICollection<Owner> GetOwnersFromACountry(int CountryId);
        bool CountryExists(int id);
    }
}