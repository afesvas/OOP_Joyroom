#include "Item.h"
#include <cstdlib>
#include <ctime>

// main�� srand(time(NULL)); �߰�

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
	// �κ��丮�� �߰�
	inventory.add(this);

	// ������ ����
	// destructor�� ȣ�� or �������ʰ� ����
}



ConsumableItem::ConsumableItem(State _state, int _due, int _left = 0, int _top = 0, int _x_range = MAP_WIDTH, int _y_range = MAP_HEIGHT) : Item(_state, _left, _top, _x_range, _y_range) {
	due = _due;
}

void ConsumableItem::obtain() {
	// �ٷ� ���
	character.state += get_state();

	// ������ ����
	// destructor�� ȣ�� or �������ʰ� ����
}

void ConsumableItem::decrease_due() {
	due--;
	if (due == 0) {
		// ������ ����
		// destructor�� ȣ�� or �������ʰ� ����
		;
	}
}

