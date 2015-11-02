#ifndef ITEM
#define ITEM

class Item {
private:
	// Ư�� ��ҿ��� �������ִ� �������� ���� �� �־ �Ʒ��� ���� ������ ����
	int left, top;	// �������� ������ ������ ����, ���� ��ǥ
	int x_range, y_range;	// �������� ������ ������ ����

	int x, y;	// �������� ��ǥ
	State state;	// ���� ��ȭ

public:
	Item(int _left = 0, int _top = 0, int _x_range = MAP_WIDTH, int _y_range = MAP_HEIGHT);
	Item(State _state, int _left = 0, int _top = 0, int _x_range = MAP_WIDTH, int _y_range = MAP_HEIGHT);
	State get_state();

	void obtain();	// �ֿ��� ��
};


class ConsumableItem : public Item {
private:
	int due;	// �������

public:
	ConsumableItem(State _state, int _due, int _left = 0, int _top = 0, int _x_range = MAP_WIDTH, int _y_range = MAP_HEIGHT);
	void obtain();	// �ֿ��� ��
	void decrease_due();	// ������� ����
};

#endif
