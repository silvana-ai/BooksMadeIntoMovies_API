﻿// <auto-generated />
using BooksMadeIntoMovies_API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BooksMadeIntoMovies_API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("BooksMadeIntoMovies_API.Entitites.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImdbId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Margaret Mitchell",
                            Description = "This is the tale of Scarlett O'Hara, the spoiled, manipulative daughter of a wealthy plantation owner, who arrives at young womanhood just in time to see the Civil War forever change her way of life. A sweeping story of tangled passion and courage, in the pages of Gone With the Wind, Margaret Mitchell brings to life the unforgettable characters that have captured readers for over seventy years.",
                            ImdbId = "tt0031381",
                            Name = "Gone with the Wind"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Mario Puzo",
                            Description = "Sonny Corleone is an old hand, while World War II veteran Michael Corleone is unused to the world of crime and reluctant to plunge into the business. Both the police and ruthless rival crime lords scent blood in the water.",
                            ImdbId = "tt0068646",
                            Name = "The Godfather"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Gillian Flynn",
                            Description = "What are you thinking, Amy? The question I've asked most often during our marriage, if not out loud, if not to the person who could answer. I suppose these questions stormcloud over every marriage: What are you thinking? How are you feeling? Who are you? What have we done to each other? What will we do?' Just how well can you ever know the person you love? This is the question that Nick Dunne must ask himself on the morning of his fifth wedding anniversary, when his wife Amy suddenly disappears. The police immediately suspect Nick. Amy's friends reveal that she was afraid of him, that she kept secrets from him. He swears it isn't true. A police examination of his computer shows strange searches. He says they aren't his. And then there are the persistent calls on his mobile phone. So what did really did happen to Nick's beautiful wife? And what was left in that half-wrapped box left so casually on their marital bed? In this novel, marriage truly is the art of war...",
                            ImdbId = "tt2267998",
                            Name = "Gone Girl"
                        },
                        new
                        {
                            Id = 4,
                            Author = "Winston Groom",
                            Description = "Whenever I really get stumped, I go visit Jenny's grave. She tells me she's always rooting for me. The Bubba Gump Shrimp Co. has gone bust and now Forrest is flat broke, sweeping floors in a New Orleans strip joint, when a fresh opportunity to play championship football puts him back in the limelight -- and in the money. But fate turns fickle again, and he's soon out on the road selling phony encyclopedias and trying to raise his son, little Forrest, who needs his father more than ever. Forrest's remarkable, touching, and utterly comic odyssey has just begun: in store for him is an explosive attempt at hog farming; his own dubious recipe for adding life to New Coke; an encounter with Oliver North of the Iran-Contra affair; and a chance yet again to unwittingly twist the nose of history.",
                            ImdbId = "tt0109830",
                            Name = "Gump & Co"
                        },
                        new
                        {
                            Id = 5,
                            Author = "Stephenie Meyer",
                            Description = "Melanie Stryder refuses to fade away. The earth has been invaded by a species that takes over the minds of their human hosts while leaving their bodies intact, and most of humanity has succumbed. Wanderer, the invading 'soul' who has been given Melanie's body, knew about the challenges of living inside a human: the overwhelming emotions, the too-vivid memories. But there was one difficulty Wanderer didn't expect: the former tenant of her body refusing to relinquish possession of her mind. Melanie fills Wanderer's thoughts with visions of the man Melanie loves - Jared, a human who still lives in hiding. Unable to separate herself from her body's desires, Wanderer yearns for a man she's never met. As outside forces make Wanderer and Melanie unwilling allies, they set off to search for the man they both love.",
                            ImdbId = "tt1517260",
                            Name = "The Host"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
