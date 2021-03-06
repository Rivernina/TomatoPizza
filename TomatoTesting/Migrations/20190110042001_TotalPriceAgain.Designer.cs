﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TomatoPizzaCafe.Data;

namespace TomatoPizzaCafe.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20190110042001_TotalPriceAgain")]
    partial class TotalPriceAgain
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TomatoPizzaCafe.Models.MakeYourOwn", b =>
                {
                    b.Property<int>("MakeYourOwnID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Crust");

                    b.Property<string>("CustomerName");

                    b.Property<int?>("OrderID");

                    b.Property<string>("Sauce");

                    b.Property<string>("Topping1");

                    b.Property<string>("Topping2");

                    b.Property<string>("Topping3");

                    b.Property<string>("Topping4");

                    b.Property<string>("Topping5");

                    b.Property<string>("Topping6");

                    b.HasKey("MakeYourOwnID");

                    b.HasIndex("OrderID");

                    b.ToTable("MakeYourOwns");
                });

            modelBuilder.Entity("TomatoPizzaCafe.Models.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerName");

                    b.Property<double>("TotalPrice");

                    b.HasKey("OrderID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("TomatoPizzaCafe.Models.OrderItem", b =>
                {
                    b.Property<int>("OrderItemID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MakeYourOwnID");

                    b.Property<int>("Number");

                    b.Property<int?>("OrderID");

                    b.Property<int?>("PizzaID");

                    b.Property<int>("Size");

                    b.HasKey("OrderItemID");

                    b.HasIndex("MakeYourOwnID");

                    b.HasIndex("OrderID");

                    b.HasIndex("PizzaID");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("TomatoPizzaCafe.Models.Pizza", b =>
                {
                    b.Property<int>("PizzaID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<double>("EightInchPrice");

                    b.Property<double>("EighteenInchPrice");

                    b.Property<double>("FourteenInchPrice");

                    b.Property<int?>("OrderID");

                    b.Property<double>("TenInchPrice");

                    b.Property<double>("TwelveInchPrice");

                    b.Property<string>("Type");

                    b.HasKey("PizzaID");

                    b.HasIndex("OrderID");

                    b.ToTable("Pizzas");
                });

            modelBuilder.Entity("TomatoPizzaCafe.Models.Topping", b =>
                {
                    b.Property<int>("ToppingID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("ToppingID");

                    b.ToTable("Toppings");
                });

            modelBuilder.Entity("TomatoPizzaCafe.Models.MakeYourOwn", b =>
                {
                    b.HasOne("TomatoPizzaCafe.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderID");
                });

            modelBuilder.Entity("TomatoPizzaCafe.Models.OrderItem", b =>
                {
                    b.HasOne("TomatoPizzaCafe.Models.MakeYourOwn", "MakeYourOwn")
                        .WithMany()
                        .HasForeignKey("MakeYourOwnID");

                    b.HasOne("TomatoPizzaCafe.Models.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderID");

                    b.HasOne("TomatoPizzaCafe.Models.Pizza", "Pizza")
                        .WithMany()
                        .HasForeignKey("PizzaID");
                });

            modelBuilder.Entity("TomatoPizzaCafe.Models.Pizza", b =>
                {
                    b.HasOne("TomatoPizzaCafe.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderID");
                });
#pragma warning restore 612, 618
        }
    }
}
