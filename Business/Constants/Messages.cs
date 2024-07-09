using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        //General Messages
        public static string MaintenanceTime = "The system is under maintenance please try later!!";


        //Car Messages
        public static string AddedCar = "The car has been added succesfuly!!";    
        public static string CarNameInvalid = "The car name must be at least two character!!";       
        public static string CarListed = "The cars are listed succesfuly!!";                
        public static string EmptyCarList = "There are no car in this list!!";        
        public static string DeletedCar = "The car has been deleted succesfuly";        
        public static string CarNotFound = "The car you entered is not found in the car list!!";        
        public static string UpdatedCar = "The car has beeen updated succesfuly!!";
        


        //Brand Messages
        public static string AddedBrand = "The brand has been added succesfuly!!";
        public static string BrandNameInvalid = "The brand name must be at least two character!!";
        public static string BrandListed = "The brands are listed succesfuly!!";
        public static string EmptyBrandList = "There are no brand in this list!!";
        public static string DeletedBrand = "The brand has been deleted succesfuly";
        public static string BrandNotFound = "The brand you entered is not found in the brand list!!";
        public static string UpdatedBrand = "The brand has beeen updated succesfuly!!";


        //Color Messages
        public static string AddedColor = "The color has been added succesfuly!!";
        public static string ColorNameInvalid = "The color name must be at least two character!!";
        public static string ColorListed = "The colors are listed succesfuly!!";
        public static string EmptyColorList = "There are no color in this list!!";
        public static string DeletedColor = "The color has been deleted succesfuly";
        public static string ColorNotFound = "The color you entered is not found in the color list!!";
        public static string UpdatedColor = "The color has beeen updated succesfuly!!";
    }
}
