namespace CourseCrawler
{
    internal interface IUseCase<T>
    {
        T Do();
    }
}