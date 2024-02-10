namespace PictureTrainer.Data
{
    public interface IImage
    {
        public List<Image> GetImages();
        public Image GetImage(int id);
        public void AddImage(Image problems);
    }
}
