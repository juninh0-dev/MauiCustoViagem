﻿using SQLite;
namespace MauiCustoViagem.Models
{
    public class Pedagio
    {
        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }
        public double Valor { get; set; }
        public string Local { get; set; }
    }
}