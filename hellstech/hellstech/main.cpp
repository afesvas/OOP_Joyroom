#include <iostream>
#include <string>

using namespace std;

void gamecenter();
int char_choose();
void story(int char_choose);
void game(int char_choose);
void print_challenge();
void ending();

int main(){

	int choose;//����ȭ�鿡���� ����

	while(1){

		//���θ޴� ���
		cout<<"welcome to HELLstech"<<endl;
		cout<<"1. ���ӽ���"<<endl;
		cout<<"2. ��������"<<endl;
		cout<<"3. ���� ����"<<endl;
		cout<<"�Է�: ";
		cin>>choose;

		if(choose == 1){
			//���ӽ���
			gamecenter();
		}
		else if(choose == 2){
			//�������� ��� 
			print_challenge();
		}
		else if(choose == 3){
			break;
		}
		else{
			cout<<"�߸��� �Է��Դϴ�"<<endl;
		}
	}

	return 0;
}

void gamecenter(){

	int character;
	character=char_choose();//ĳ���ͼ���
	story(character);//���丮���
	game(character);//����

}

void print_challenge(){

}

int char_choose(){
	int choose;

	while(1){
		//ĳ���� ����
		cout<<"ĳ���͸� ���ÿ�"<<endl;
		cout<<"1. ������ ������"<<endl;
		cout<<"2. ������ ������"<<endl;
		cout<<"3. ���� ������"<<endl;
		cout<<"4. ���� ������"<<endl;
		cout<<"�Է�: ";
		cin>>choose;

		if(choose == 1){
			cout<<"������ �����̸� ���̽��ϴ�"<<endl;
			break;
		}
		else if(choose == 2){
			cout<<"������ �����̸� ���̽��ϴ�"<<endl;
			break;
		}
		else if(choose == 3){
			cout<<"���� �����̸� ���̽��ϴ�"<<endl;
			break;
		}
		else if(choose == 4){
			cout<<"���� �����̸� ���̽��ϴ�"<<endl;
			break;
		}
		else{
			cout<<"�߸��� �Է��Դϴ�"<<endl;
		}
	}
	return choose;
}

void story(int char_choose){
	//���丮 ���
	cout<<"�������� ���߽��ϴ�"<<endl;
	cout<<"�������� ������ �� �����ؿ��� ��Ƴ��ƾ��մϴ�"<<endl;
	cout<<"��Ƴ��ƶ�! �����!"<<endl;
	cout<<"�ƾ�... ���߾��..."<<endl;
	//ĳ���͸��� �ٸ� ���丮
	if(char_choose == 1){
		cout<<"���� �󸶳� ������ؼ� ���� �������ε�, ���� �������� �̷��� �ʾ�!"<<endl;
		cout<<"��â! ��â�� �ʿ��ϴ�!"<<endl;
	}
	else if (char_choose == 2){
		cout<<"(������� �ƴ϶� ���� ��ȭ�� ���� ����� ���� �ʴ´�)"<<endl;
	}
	else if (char_choose == 3){
		cout<<"���� ���ߴ� ���̶� ���� ���ߴٴ� �ǰ��� ���� �ʴ±�"<<endl;
	}
	else if (char_choose == 4){
		cout<<"(������� �ƴ϶� ���� ��ȭ�� ���� ����� ���� �ʴ´�)"<<endl;
	}
}

void game(int char_choose){

	string building_name;
	string item_name;
	string human_name;

	//ĳ���Ϳ� ���� �Լ��� char_choose�� ������ ��������

	cout<<"�ǹ��� ����: ";
	cin>>building_name;
	//�ǹ��� ����
	cout<<endl;

	cout<<"item �ݱ�: ";
	cin>>item_name;
	//�������� �ֿﶧ
	cout<<endl;

	cout<<"����� ������: ";
	cin>>human_name;
	//�ǹ��� ����
	cout<<endl;

	ending();//�¸����� ���� �Լ�

}

void ending(){//ĳ���Ϳ� �ش��ϴ� �Ű����� �߰���
	//ĳ���� ���ȿ� ���� ����

	cout<<"����� �ｺ�ؿ��� ��Ƴ��Ҵ�!"<<endl;
	//��������ǥ������� ���

	cout<<"�ٽ��ѹ� ��Ƴ��ƺ�����"<<endl;
}

