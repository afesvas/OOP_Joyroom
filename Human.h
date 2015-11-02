#pragma once
#include <string>
#include <iostream>

using namespace std;

class Human {
private:
	int x, y;
	string department;
	string *message;			// 터치 할 시 말하는 내용 , 여러번 말 할 수도 있다
	bool visibility;			// 사라지는 여부

public:
	Human() {
		x = 10; y = 10; department = "산업경영공학과"; message = new string("나는 누구인가..?");
		visibility = true;
	}
	//void stat_change();			// character의 스탯을 변화시켜 주는 함수
	void talk();
	void invisible();		// 만났을 때 사라지게 해주는 함수
	void print_message();
};

class specialist : public Human {
private:
	int item;			// 일단 뭐로 할 지 몰라 아이템을 int형으로 함.

public:
	specialist() : Human() {
		item = 941121;				// 특수한 아이템을 제공함
	}
	int get_item(); { return item; }		// 아이템을 주는 함수

};

void Human::talk() {
	cout << " 외롭다 .... 나의 뮤즈가 되어 줄래?" << endl;
	invisible();

	cout << "그리고 그는 그렇게 한 줌의 재가 되어 사라져따..." << endl;
}

void Human::print_message() {
	cout << message[0] << endl;				// 메시지가 여러개 인 경우는 단계별로 출력합니다 또는 for 문 이용
}

void Human::invisible() {
	visibility = 0;
}
