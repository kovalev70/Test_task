// Task6
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


// ���� �� ����� �������� ����������� � �������� � ����������� ��������� ������� T
class Instantiator<T>
{
    public T instance;
    public Instantiator(T obj)
    {
        instance = obj;
    }
}


// Task9
// ���������� ���� ���������:

SELECT COUNT(id) AS total_students
FROM students;

// ���������� ��������� � ������ "����":

SELECT COUNT(id) AS ivan_students
FROM students
WHERE name = '����';

// ���������� ���������, ��������� ����� 1 �������� 2020 ����:

SELECT COUNT(id) AS students_after_2020
FROM students
WHERE created_at > '2020-09-01';

// ������������ ���������� ����� � ������ ��������:

SELECT MAX(child_count) AS max_children_count
FROM (
    SELECT parent_id, COUNT(id) AS child_count
    FROM students
    GROUP BY parent_id
) AS children_count_table;