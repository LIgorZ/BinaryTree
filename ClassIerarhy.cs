using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    class ClassIerarhy
    {
    }

    class Client
    {
        private IProductA a;
        private IProductB b;

        public Client(IFactory parameter)
        { 
        
        }
    }

    interface IProductA
    {
        class ProductA1
        {

        }

        class ProductA2
        {

        }

    }

    interface IProductB
    {
        class ProductB1
        {

        }
        class ProductB2
        {

        }
    }

    interface IFactory
    {
        class Factory1
        {

        }

        class Factory2
        {

        }
    }


}
