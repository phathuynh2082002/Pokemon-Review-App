﻿using PokemonReivewApp.Models;

namespace PokemonReivewApp.Interfaces
{
    public interface IOwnerRepository
    {
        ICollection<Owner> GetOwners();
        Owner GetOwner(int ownerId);
        ICollection<Owner> GetOwnersByAPokemon(int pokeId);
        ICollection<Pokemon> GetPokemonsByOwner(int ownerId);
        bool OwnerExists(int ownerId);
        bool CreateOwner(Owner owner);
        bool UpdateOwner(Owner owner);
        bool DeleteOwner(Owner owner);

        bool Save();
    }
}
