﻿// <auto-generated />
using DrugBot.DataBase.Data.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DrugBot.DataBase.Migrations.Prediction
{
    [DbContext(typeof(PredictionDbContext))]
    partial class PredictionDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("DrugBot.DataBase.Data.PredictionData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Prediction")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Predictions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Prediction = "Перед вами прямая дорога к заветной цели. Получится все, что вы задумали."
                        },
                        new
                        {
                            Id = 2,
                            Prediction = "Нужные люди или счастливое и удачное стечение обстоятельств помогут вам добиться желаемого."
                        },
                        new
                        {
                            Id = 3,
                            Prediction = "Препятствия, возникающие одно за другим, могут помешать выполнению ваших планов."
                        },
                        new
                        {
                            Id = 4,
                            Prediction = "Реализация целей зависит от ваших усилий. Если у вас хватит терпения следовать тому, что вы наметили, — успех возможен."
                        },
                        new
                        {
                            Id = 5,
                            Prediction = "Займитесь накоплением знаний, в данный момент это нужно вам больше всего."
                        },
                        new
                        {
                            Id = 6,
                            Prediction = "Шаг за шагом вы приближаетесь к намеченной цели. «Тише едешь — дальше будешь» — в данном случае для вас."
                        },
                        new
                        {
                            Id = 7,
                            Prediction = "Временные трудности и испытания. Сохраните достоинство и не теряйте из виду цель."
                        },
                        new
                        {
                            Id = 8,
                            Prediction = "Обстоятельства сложатся удачно, добавьте смекалки или силы, чтобы убрать противостояние вашим планам."
                        },
                        new
                        {
                            Id = 9,
                            Prediction = "Имейте терпение и добьетесь всего, что пожелаете. В данном случае поспешные действия неуместны.Можете рассчитывать только на плоды своих усилий. Помощь со стороны может оказаться «медвежьей услугой»."
                        },
                        new
                        {
                            Id = 10,
                            Prediction = "Вы окажетесь в выигрыше. Это будет сюрпризом, так как может получиться не в то время, в какое вы предполагаете."
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
