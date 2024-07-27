namespace Dapperr.Dtos.PropertyDto
{
	public class UpdatePropertyDto
	{
        public int PropertyId { get; set; }
        public string PropertyTitle { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int SquareMeter { get; set; }
        public int BedRooms { get; set; }
        public int BathRooms { get; set; }
      
        public string Heating { get; set; }
        public DateTime Date { get; set; }
        public bool IsFeatured { get; set; }
        public int ImagesId { get; set; }
        public int TypeId { get; set; }
        public int LocationId { get; set; }
        public int AgentId { get; set; }
        public int TagId { get; set; }

        public int StatusId { get; set; }
        public string VideoUrl { get; set; }
    }
}
