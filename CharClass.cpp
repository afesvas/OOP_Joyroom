#include <iostream>
#include "CharClass.h"

int Character::get_charm(){
	return charm;
}
int Character::get_health(){
	return health;
}
int Character::get_gpa(){
	return gpa;
}
/*
Inventory Character::get_inventory(){
	return inven;
}
*/
void Character::set_charm(int _charm){
	charm = _charm;
}
void Character::set_health(int _health){
	health = _health;
}
void Character::set_gpa(int _gpa){
	gpa = _gpa;
}
/*
void Character::add_item(Item new_item){
}
*/
/*
bool Character::discard_item(Item dis_item){
}
*/