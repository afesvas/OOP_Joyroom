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

	int choose;//메인화면에서의 선택

	while(1){

		//메인메뉴 출력
		cout<<"welcome to HELLstech"<<endl;
		cout<<"1. 게임실행"<<endl;
		cout<<"2. 도전과제"<<endl;
		cout<<"3. 게임 종료"<<endl;
		cout<<"입력: ";
		cin>>choose;

		if(choose == 1){
			//게임실행
			gamecenter();
		}
		else if(choose == 2){
			//도전과제 출력 
			print_challenge();
		}
		else if(choose == 3){
			break;
		}
		else{
			cout<<"잘못된 입력입니다"<<endl;
		}
	}

	return 0;
}

void gamecenter(){

	int character;
	character=char_choose();//캐릭터선택
	story(character);//스토리출력
	game(character);//게임

}

void print_challenge(){

}

int char_choose(){
	int choose;

	while(1){
		//캐릭터 선택
		cout<<"캐릭터를 고르시오"<<endl;
		cout<<"1. 새내기 공돌이"<<endl;
		cout<<"2. 새내기 공순이"<<endl;
		cout<<"3. 늙은 공돌이"<<endl;
		cout<<"4. 늙은 공순이"<<endl;
		cout<<"입력: ";
		cin>>choose;

		if(choose == 1){
			cout<<"새내기 공돌이를 고르셨습니다"<<endl;
			break;
		}
		else if(choose == 2){
			cout<<"새내기 공순이를 고르셨습니다"<<endl;
			break;
		}
		else if(choose == 3){
			cout<<"늙은 공돌이를 고르셨습니다"<<endl;
			break;
		}
		else if(choose == 4){
			cout<<"늙은 공순이를 고르셨습니다"<<endl;
			break;
		}
		else{
			cout<<"잘못된 입력입니다"<<endl;
		}
	}
	return choose;
}

void story(int char_choose){
	//스토리 출력
	cout<<"포스텍이 망했습니다"<<endl;
	cout<<"여러분은 지옥이 된 포스텍에서 살아남아야합니다"<<endl;
	cout<<"살아남아라! 공대생!"<<endl;
	cout<<"아아... 망했어요..."<<endl;
	//캐릭터마다 다른 스토리
	if(char_choose == 1){
		cout<<"내가 얼마나 노오력해서 들어온 포스텍인데, 나의 포스텍은 이러지 않아!"<<endl;
		cout<<"죽창! 죽창이 필요하다!"<<endl;
	}
	else if (char_choose == 2){
		cout<<"(여대생이 아니라 무슨 대화를 할지 상상이 가지 않는다)"<<endl;
	}
	else if (char_choose == 3){
		cout<<"원래 망했던 곳이라 별로 망했다는 실감이 나지 않는군"<<endl;
	}
	else if (char_choose == 4){
		cout<<"(여대생이 아니라 무슨 대화를 할지 상상이 가지 않는다)"<<endl;
	}
}

void game(int char_choose){

	string building_name;
	string item_name;
	string human_name;

	//캐릭터에 관한 함수에 char_choose를 변수로 넣을것임

	cout<<"건물에 들어가기: ";
	cin>>building_name;
	//건물에 들어갈때
	cout<<endl;

	cout<<"item 줍기: ";
	cin>>item_name;
	//아이템을 주울때
	cout<<endl;

	cout<<"사람을 만날때: ";
	cin>>human_name;
	//건물에 들어갈때
	cout<<endl;

	ending();//승리조건 판정 함수

}

void ending(){//캐릭터에 해당하는 매개변수 추가요
	//캐릭터 스탯에 따른 판정

	cout<<"당신은 헬스텍에서 살아남았다!"<<endl;
	//성적통지표모양으로 출력

	cout<<"다시한번 살아남아보시지"<<endl;
}

