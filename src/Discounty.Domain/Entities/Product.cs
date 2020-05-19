namespace Discounty.Domain.Entities
{
    /// <summary>
    /// Entity that represents product entity.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Primary key.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of the product.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Foreign key to the Category entity.
        /// </summary>
        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
