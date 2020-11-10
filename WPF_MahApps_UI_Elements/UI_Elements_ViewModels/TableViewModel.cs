using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using WPF_MahApps_UI_Elements.Models;

namespace WPF_MahApps_UI_Elements.UI_Elements_ViewModels
{
    public class TableViewModel
    {
        public ObservableCollection<Product> Products { get; }

        public TableViewModel()
        {
            Products = new ObservableCollection<Product> {
            new Product
            {
                Id=1,
                name="ProductA",
                specs= new List<Spec>
                {
                    new Spec
                    {
                        Id=1,
                        name="SpecA",
                        ingredients= new List<Ingredient>
                        {
                            new Ingredient
                            {
                                Id=1,
                                amount=10.10,
                                name="Ingredient 1",
                                image="https://homepages.cae.wisc.edu/~ece533/images/fruits.png"

                            },
                            new Ingredient
                            {
                                Id=2,
                                amount=20.20,
                                name="Ingredient 2",
                                image="https://homepages.cae.wisc.edu/~ece533/images/peppers.png"

                            }
                        }
                    },
                    new Spec
                    {
                        Id=2,
                        name="SpecB",
                        ingredients= new List<Ingredient>
                        {
                            new Ingredient
                            {
                                Id=3,
                                amount=30.30,
                                name="Ingredient 3",
                                image="https://homepages.cae.wisc.edu/~ece533/images/fruits.png"

                            },
                            new Ingredient
                            {
                                Id=4,
                                amount=40.40,
                                name="Ingredient 4",
                                image="https://homepages.cae.wisc.edu/~ece533/images/peppers.png"

                            }
                        }
                    }
                }

            },
            new Product
            {
                Id=2,
                name="ProductB",
                specs= new List<Spec>
                {
                    new Spec
                    {
                        Id=3,
                        name="SpecC",
                        ingredients= new List<Ingredient>
                        {
                            new Ingredient
                            {
                                Id=3,
                                amount=30.30,
                                name="Ingredient 3",
                                image="https://homepages.cae.wisc.edu/~ece533/images/fruits.png"

                            },
                            new Ingredient
                            {
                                Id=5,
                                amount=50.50,
                                name="Ingredient 5",
                                image="https://homepages.cae.wisc.edu/~ece533/images/peppers.png"

                            }
                        }
                    }
                }
            }
            };
        }
    }
}
