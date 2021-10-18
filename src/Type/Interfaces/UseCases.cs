namespace CourseCrawler
{
    internal interface IUseCase<T>
    {
        // Do
        T Do();
    }
}