#include "Item.h"
#include <cstdlib>
#include <ctime>

// main에 srand(time(NULL)); 추가

string Item::get_name() { return name; }

Item::Item(int _left = 0, int _top = 0, int _x_range = MAP_WIDTH, int _y_range = MAP_HEIGHT) {
	x = rand()%_x_range + _left;
	y = rand()%_y_range + _top;
	state.health = 0;
	state.GPA = 0;
	state.charm = 0;
}

Item::Item(State _state, int _left = 0, int _top = 0, int _x_range = MAP_WIDTH, int _y_range = MAP_HEIGHT) {
	x = rand()%_x_range + _left;
	y = rand()%_y_range + _top;
	state.health = _state.health;
	state.GPA = _state.GPA;
	state.charm = _state.charm;
}

void Item::obtain() {
	// 인벤토리에 추가
	inventory.add(this);

	// 아이템 제거
	// destructor를 호출 or 보이지않게 설정
}



ConsumableItem::ConsumableItem(State _state, int _left = 0, int _top = 0, int _x_range = MAP_WIDTH, int _y_range = MAP_HEIGHT) : Item(_state, _left, _top, _x_range, _y_range) { }

void ConsumableItem::obtain() {
	// 바로 사용
	character.state += get_state();

	// 아이템 제거
	// destructor를 호출 or 보이지않게 설정
}
