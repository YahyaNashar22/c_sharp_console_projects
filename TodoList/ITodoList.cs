interface ITodoList
{
  void AddTask(string task);

  void RemoveTask(int index);

  void ListAll();

  void Save();

  void Load();
}