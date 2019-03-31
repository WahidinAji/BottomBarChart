using SfChart.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SfChart.ViewModels
{
    public class ChartViewModel {
        public ObservableCollection<Book> Data { get; set; }

        public ChartViewModel() {
            Data = new ObservableCollection<Book>();
            FillData();
        }

        private void FillData() {
            Book book = new Book() {
                Name = "Anu 1",
                Quantity = 23
            };

            Data.Add(book);

            Book book2 = new Book() {
                Name = "Anu 2",
                Quantity = 12
            };

            Data.Add(book2);

            Book book3 = new Book() {
                Name = "Anu 3",
                Quantity = 4
            };
            Data.Add(book3);

            Book book4 = new Book() {
                Name = "Anu 4",
                Quantity = 45
            };
            Data.Add(book4);

        }
    }
}
