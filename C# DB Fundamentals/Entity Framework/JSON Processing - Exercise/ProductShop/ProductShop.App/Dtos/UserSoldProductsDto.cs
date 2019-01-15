namespace ProductShop.App.Dtos
{
    using System.Collections.Generic;

    public class UserSoldProductsDto
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
        
        public ICollection<SoldProductBuyerDto> SoldProducts { get; set; }
    }
}
