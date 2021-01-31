using BooksMadeIntoMovies_API.Entitites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksMadeIntoMovies_API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Book>()
                .HasData(
                    new Book { Id = 1, Name = "Gone with the Wind", Description = "This is the tale of Scarlett O'Hara, the spoiled, manipulative daughter of a wealthy plantation owner, who arrives at young womanhood just in time to see the Civil War forever change her way of life. A sweeping story of tangled passion and courage, in the pages of Gone With the Wind, Margaret Mitchell brings to life the unforgettable characters that have captured readers for over seventy years.", Author = "Margaret Mitchell", ImdbId = "tt0031381" },
                    new Book { Id = 2, Name = "The Godfather", Description = "Sonny Corleone is an old hand, while World War II veteran Michael Corleone is unused to the world of crime and reluctant to plunge into the business. Both the police and ruthless rival crime lords scent blood in the water.", Author = "Mario Puzo", ImdbId = "tt0068646" },
                    new Book { Id = 3, Name = "Gone Girl", Description = "What are you thinking, Amy? The question I've asked most often during our marriage, if not out loud, if not to the person who could answer. I suppose these questions stormcloud over every marriage: What are you thinking? How are you feeling? Who are you? What have we done to each other? What will we do?' Just how well can you ever know the person you love? This is the question that Nick Dunne must ask himself on the morning of his fifth wedding anniversary, when his wife Amy suddenly disappears. The police immediately suspect Nick. Amy's friends reveal that she was afraid of him, that she kept secrets from him. He swears it isn't true. A police examination of his computer shows strange searches. He says they aren't his. And then there are the persistent calls on his mobile phone. So what did really did happen to Nick's beautiful wife? And what was left in that half-wrapped box left so casually on their marital bed? In this novel, marriage truly is the art of war...", Author = "Gillian Flynn", ImdbId = "tt2267998" },
                    new Book { Id = 4, Name = "Gump & Co", Description = "Whenever I really get stumped, I go visit Jenny's grave. She tells me she's always rooting for me. The Bubba Gump Shrimp Co. has gone bust and now Forrest is flat broke, sweeping floors in a New Orleans strip joint, when a fresh opportunity to play championship football puts him back in the limelight -- and in the money. But fate turns fickle again, and he's soon out on the road selling phony encyclopedias and trying to raise his son, little Forrest, who needs his father more than ever. Forrest's remarkable, touching, and utterly comic odyssey has just begun: in store for him is an explosive attempt at hog farming; his own dubious recipe for adding life to New Coke; an encounter with Oliver North of the Iran-Contra affair; and a chance yet again to unwittingly twist the nose of history.", Author = "Winston Groom", ImdbId = "tt0109830" },
                    new Book { Id = 5, Name = "The Host", Description = "Melanie Stryder refuses to fade away. The earth has been invaded by a species that takes over the minds of their human hosts while leaving their bodies intact, and most of humanity has succumbed. Wanderer, the invading 'soul' who has been given Melanie's body, knew about the challenges of living inside a human: the overwhelming emotions, the too-vivid memories. But there was one difficulty Wanderer didn't expect: the former tenant of her body refusing to relinquish possession of her mind. Melanie fills Wanderer's thoughts with visions of the man Melanie loves - Jared, a human who still lives in hiding. Unable to separate herself from her body's desires, Wanderer yearns for a man she's never met. As outside forces make Wanderer and Melanie unwilling allies, they set off to search for the man they both love.", Author = "Stephenie Meyer", ImdbId = "tt1517260" }
                );
        }
    }
}
