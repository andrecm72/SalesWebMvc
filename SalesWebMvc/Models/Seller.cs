﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Seller
    {
        private int v1;
        private string v2;
        private string v3;
        private DateTime dateTime;
        private object value;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller()
        {

        }
        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }

        public Seller(int v1, string v2, string v3, DateTime dateTime, object value)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.dateTime = dateTime;
            this.value = value;
        }

        public void AddSales(SalesRecord sr) 
        {
            Sales.Add(sr);
        }
        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);     
        }
        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }

        internal static double Sum(Func<object, object> value)
        {
            throw new NotImplementedException();
        }
    }
}
