using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Projet.Data;
using System;
using System.Linq;
namespace Projet.Models;
public static class SeedData // Ajout d’une nouvelle classe SeedData dans Models pour créer la base et ajouter un film si besoin
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new ProjetContext(
        serviceProvider.GetRequiredService<
        DbContextOptions<ProjetContext>>()))
        {
            context.Database.EnsureCreated();
            // S’il y a déjà des films dans la base
            if (context.Pays.Any())
            {
                return; // On ne fait rien
            }
            else { 
                // Sinon on en ajoute un
                context.Pays.AddRange(
                new Pays
                {
                    nom = "France",
                    continent = " Europe"
                }
                );
            }
            if (context.Population.Any())
            {
                return;
            }
            else
            {

                context.Population.AddRange(
            new Population
            {
                nombre = 100000,
                annee = 1920
            }
            );
            }
            context.SaveChanges();
        }
    }
}
