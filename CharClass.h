#include <iostream>

class Character{
private:
	int gender;					//����
	int level;					//������ or �峻��
	int charm;					//�ŷ�����
	int health;					//ü��
	int gpa;					//����
	//Inventory inven;			//�κ��丮
public:
	int get_charm();
	int get_health();
	int get_gpa();
	//Inventory get_inventory();
	void set_charm(int _charm);
	void set_health(int _health);
	void set_gpa(int _gpa);					//����, ���̵��� �ٲ��� ���� ���̱� ������ getset �Լ��� ������ ����
	//void add_item(Item new_item);					//�κ��丮�� ������ �߰�
	//bool discard_item(Item dis_item);				//�κ��丮���� ������ ����. ���� �Ұ����ϰų� ���� �������̸� false ����
};