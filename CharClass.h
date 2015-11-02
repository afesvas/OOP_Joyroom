#include <iostream>

#ifndef CHAR
#define CHAR

class Character{
private:
	int gender;					//성별
	int level;					//새내기 or 헌내기
	int charm;					//매력지수
	int health;					//체력
	int gpa;					//학점
	//Inventory inven;			//인벤토리
public:
	int get_charm();
	int get_health();
	int get_gpa();
	//Inventory get_inventory();
	void set_charm(int _charm);
	void set_health(int _health);
	void set_gpa(int _gpa);					//성별, 난이도는 바뀌지 않을 것이기 때문에 getset 함수를 만들지 않음
	//void add_item(Item new_item);					//인벤토리에 아이템 추가
	//bool discard_item(Item dis_item);				//인벤토리에서 아이템 삭제. 삭제 불가능하거나 없는 아이템이면 false 리턴
};

#endif
