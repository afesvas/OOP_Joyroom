#ifndef ITEM
#define ITEM

class Item {
private:
	// 특정 장소에만 떨어져있는 아이템이 있을 수 있어서 아래와 같이 구역을 정함
	int left, top;	// 아이템이 존재할 구역의 왼쪽, 위쪽 좌표
	int x_range, y_range;	// 아이템이 존재할 구역의 범위

	int x, y;	// 아이템의 좌표
	State state;	// 스탯 변화

public:
	Item(int _left = 0, int _top = 0, int _x_range = MAP_WIDTH, int _y_range = MAP_HEIGHT);
	Item(State _state, int _left = 0, int _top = 0, int _x_range = MAP_WIDTH, int _y_range = MAP_HEIGHT);
	State get_state();

	void obtain();	// 주웠을 때
};


class ConsumableItem : public Item {
private:
	int due;	// 유통기한

public:
	ConsumableItem(State _state, int _due, int _left = 0, int _top = 0, int _x_range = MAP_WIDTH, int _y_range = MAP_HEIGHT);
	void obtain();	// 주웠을 때
	void decrease_due();	// 유통기한 감소
};

#endif
