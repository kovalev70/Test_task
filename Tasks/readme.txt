// ������� ����������� ���� where T : new() 
// �� �����������, ��� ������������ ��� T �������� ����������� �� ���������
class Instantiator<T> where T : new()
{
    public T instance;
    public Instantiator()
    {
        instance = new T();
    }
}


���� �� ����� �������� ����������� � �������� � ����������� ��������� ������� T
class Instantiator<T>
{
    public T instance;
    public Instantiator(T obj)
    {
        instance = obj;
    }
}