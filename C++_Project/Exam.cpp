# include <iostream>
# include <conio.h>
# include <ctime>
# include <cstdlib>
# include <vector>
# include <string>
# include <stdio.h>
# include <stdlib.h>
# include <algorithm>
# include <bits/stdc++.h>


using namespace std;

class hero{
	public:
		vector<int> inv; 
		string name, wename="Dagger" , armname="Leather Armor";
		string weaname[8] = {"Dagger","Short Sword","Longsword","Battle Axe","Leather Armor","Chain Mail","Breast Plate","Full Plate"};
		string weainfl[8] = {"4","6","8","12","2","4","6","8"};
		int HP=40,AC=2,W=4;
		void inventory(){
			cout<<"Your inventory is "<<endl;
			for (int i=0;i<inv.size();++i)
				cout<<i+1 <<") "<<inv.at(i)<<endl;
			cout<<"Your weapon is "<<wename<<" with the power of "<<W<<endl;
			cout<<"Your armor is "<<armname<<" with the power of "<<AC<<endl;
			getch();
			
		}
		void getname()
		{
			cout<<"Write your name"<<endl;
			cin>>name;
			system("cls");
			cout<<"Hello "<<name<<"!"<<endl;
			cout<<"Welcome to our game. Your goal is to defeat the BOSS!"<<endl;
			cout<<"Your starter stats are: HP=40, Armor=2 Weapon=Dagger Damage=1d4"<<endl;
			cout<<"You walk with WASD through the maze and I for Inventory"<<endl;
			cout<<"X<-- You"<<endl<<"E<-- Enemy"<<endl<<"C<-- Chest"<<endl<<"H<-- Healing Potion"<<endl<<"B<--Boss"<<endl;
			cout<<"S T A R T !"<<endl;
			getch();
			system("cls");
		}
		void getlife()
		{
			int x;
			x=(rand() % 40)+10;
			inv.push_back(x);
			cout<<endl<<"You got a Healing Potion. Your current inventory is "<<endl;
			for (int i=0;i<inv.size();++i)
				cout<<i+1 <<") "<<inv.at(i)<<endl;
			getch();
		}
		void getchest()
		{
			int i;
			i=(rand() % 9)+1;
			i--;
			if (i>=4)
			{
				int x=atoi(weainfl[i].c_str());
				cout<<endl<<"You got a "<<weaname[i]<<" that gives you "<<x<<" armor."<<endl;
				if(x>AC)
				{
					cout<<"Your "<<armname<<" has been replaced with "<<weaname[i]<<" and your armor is now "<<x;
					armname=weaname[i];
					AC>>x;
				}
				else
					cout<<"Your current Armor is better or equal than "<<weaname[i]<<" so it won't be changed"<<endl;
			getch();
			}
			else
			{
				int x=atoi(weainfl[i].c_str());
				cout<<endl<<"You got a "<<weaname[i]<<" that gives you "<<x<<" attack."<<endl;
				if(x>W)
				{
					cout<<"Your "<<wename<<" has been replaced with "<<weaname[i]<<" and your weapon attack is now "<<x;
					wename=weaname[i];
					W>>x;
				}
				else
					cout<<"Your current Weapon is better or equal than "<<weaname[i]<<" so it won't be changed"<<endl;
			getch();
			}
		}
};

class monster : public hero {
	public:
		vector<int> LP;
		vector<int> ArC;
		vector<int> DP;
		int life,armor,weapon,dam;

		void stats(){
			LP.push_back(20);
			LP.push_back(25);
			LP.push_back(30);
			ArC.push_back(2);
			ArC.push_back(3);
			ArC.push_back(4);
			DP.push_back(4);
			DP.push_back(5);
			DP.push_back(6);
			random_shuffle(LP.begin(),LP.end());
			random_shuffle(ArC.begin(),ArC.end());
			random_shuffle(DP.begin(),DP.end());
			life=LP[2];
			armor=ArC[2];
			weapon=DP[2];
		}
		void match()
		{
			stats();
			system("cls");
			cout<<"You just faced a monster"<<endl;
			cout<<"The monster's stats are "<<endl<<"Life : "<<life<<endl<<"Armor : "<<armor<<endl<<"Weapon Damage : 1d"<<weapon<<endl;
			getch();
			while (life>0 && HP>0)
			{
				int x,y,i;
				system("cls");
				cout<<"You will roll both a dice. The one with the bigger number plays first"<<endl;
				getch();
				x=(rand() % 6)+1;
				cout<<"You got "<<x<<endl;
				y=(rand() % 6)+1;
				cout<<"The monster got "<<y<<endl;
				if (x>y)
				{
					cout<<"You got higher so you play first"<<endl;
					getch();
					i=2;
				}
				else if (y>x)
				{
					cout<<"You got lower so you play second"<<endl;
					getch();
					i=1;
				}
				else 
				{
					cout<<"You got tie so you will roll it again"<<endl; 
					i=3;
				}
				if (i==1)
				{
					dam=(rand() % weapon)+1;
					cout<<"You got "<<dam<<" damage"<<endl;
					dam=dam-AC;
					if (dam<0)
						dam=0;
					HP=HP-dam;
					cout<<"Your life now is "<<HP<<endl;
					getch();
					cout<<"It's your turn. You have 2 options. Press :"<<endl<<"1.Attack"<<endl<<"2.Inventory"<<endl;
					int c=0;
					cin>>c;
					if (c==1)
					{
						dam=(rand() % W)+1;
						cout<<"You did "<<dam<<" damage"<<endl;
						dam=dam-armor;
						if (dam<0)
							dam=0;
						life=life-dam;
						cout<<"The monster's life now is "<<life<<endl;
						getch();
					}
					else if (c==2)
					{
						if (inv.empty())
						{
							cout<<"You have nothing in the inventory, so you go to attack"<<endl;
							getch();
							dam=(rand() % W)+1;
							cout<<"You did "<<dam<<" damage"<<endl;
							dam=dam-armor;
							if (dam<0)
								dam=0;
							life=life-dam;
							cout<<"The monster's life now is "<<life<<endl;
							getch();
						}
						else
						{
							cout<<"Your inventory is"<<endl;
							for (int i=0;i<inv.size();++i)
								cout<<i+1 <<") "<<inv.at(i)<<endl;
							cout<<"Which one would you like to take?"<<endl;
							int g;
							cin>>g;
							HP=HP+inv[g-1];
							inv.erase(inv.begin()+g);
							cout<<"Your new life is "<<HP<<endl;
							getch();
						}
					}
				}
				else if (i==2)
				{
					cout<<"It's your turn. You have 2 options. Press :"<<endl<<"1.Attack"<<endl<<"2.Inventory"<<endl;
					int c=0;
					cin>>c;
					if (c==1)
					{
						dam=(rand() % W)+1;
						cout<<"You did "<<dam<<" damage"<<endl;
						dam=dam-armor;
						if (dam<0)
							dam=0;
						life=life-dam;
						cout<<"The monster's life now is "<<life<<endl;
						getch();
					}
					else if (c==2)
					{
						if (inv.empty())
						{
							cout<<"You have nothing in the inventory, so you go to attack"<<endl;
							getch();
							dam=(rand() % W)+1;
							cout<<"You did "<<dam<<" damage"<<endl;
							dam=dam-armor;
							if (dam<0)
								dam=0;
							life=life-dam;
							cout<<"The monster's life now is "<<life<<endl;
							getch();
						}
						else
						{
							cout<<"Your inventory is"<<endl;
							for (int i=0;i<inv.size();++i)
								cout<<i+1 <<") "<<inv.at(i)<<endl;
							cout<<"Which one would you like to take?"<<endl;
							int g;
							cin>>g;
							HP=HP+inv[g-1];
							inv.erase(inv.begin()+g);
							cout<<"Your life now  is "<<HP<<endl;
							getch();
						}
					}
					dam=(rand() % weapon)+1;
					cout<<"You got "<<dam<<" damage"<<endl;
					dam=dam-AC;
					if (dam<0)
						dam=0;
					HP=HP-dam;
					cout<<"Your life now is "<<HP<<endl;
					getch();
				}
				else
					cout<<"You got a tie, so you roll again"<<endl;
			}
			if (HP<=0)
			{
				cout<<"Unfortunately you lost the game, so YOU DIED!"<<endl;
				exit(0);
			}
			else if (life<=0)
			{
				cout<<"You beat the monster. Continue your journey!"<<endl;
				getch();
			}
		
		}

};
class boss: public monster {
	public:
		int LB,AB,WB,SL;
		void match1(){
			stats();
			LB=life;
			SL=life;
			AB=armor;
			WB=weapon;
			system("cls");
			cout<<"You just faced the Boss."<<endl;
			cout<<"The Boss' stats are "<<endl<<"Life : "<<LB<<endl<<"Armor : "<<AB<<endl<<"Weapon Damage : 1d"<<WB<<endl;
			getch();
			while (LB>(SL/5) && HP>0)
			{
				int x,y,i;
				system("cls");
				cout<<"You will roll both a dice. The one with the bigger number plays first"<<endl;
				getch();
				x=(rand() % 6)+1;
				cout<<"You got "<<x<<endl;
				y=(rand() % 6)+1;
				cout<<"The Boss got "<<y<<endl;
				if (x>y)
				{
					cout<<"You got higher so you play first"<<endl;
					getch();
					i=2;
				}
				else if (y>x)
				{
					cout<<"You got lower so you play second"<<endl;
					getch();
					i=1;
				}
				else 
				{
					cout<<"You got tie so you will roll it again"<<endl; 
					i=3;
				}
				if (i==1)
				{
					dam=(rand() % WB)+1;
					cout<<"You got "<<dam<<" damage"<<endl;
					dam=dam-AC;
					if (dam<0)
						dam=0;
					HP=HP-dam;
					cout<<"Your life now is "<<HP<<endl;
					getch();
					cout<<"It's your turn. You have 2 options. Press :"<<endl<<"1.Attack"<<endl<<"2.Inventory"<<endl;
					int c=0;
					cin>>c;
					if (c==1)
					{
						dam=(rand() % W)+1;
						cout<<"You did "<<dam<<" damage"<<endl;
						dam=dam-AB;
						if (dam<0)
							dam=0;
						LB=LB-dam;
						cout<<"The Boss' life now is "<<life<<endl;
						getch();
					}
					else if (c==2)
					{
						if (inv.empty())
						{
							cout<<"You have nothing in the inventory, so you go to attack"<<endl;
							getch();
							dam=(rand() % W)+1;
							cout<<"You did "<<dam<<" damage"<<endl;
							dam=dam-AB;
							if (dam<0)
								dam=0;
							LB=LB-dam;
							cout<<"The Boss' life now is "<<life<<endl;
							getch();
						}
						else
						{
							for (int i=0;i<inv.size();++i)
								cout<<"Your inventory is "<<endl<<i+1 <<") "<<inv.at(i)<<endl;
							cout<<"Which one would you like to take?"<<endl;
							int g;
							cin>>g;
							HP=HP+inv[g-1];
							inv.erase(inv.begin()+g);
							cout<<"Your new life is "<<HP<<endl;
							getch();
						}
					}
				}
				else if (i==2)
				{
					cout<<"It's your turn. You have 2 options. Press :"<<endl<<"1.Attack"<<endl<<"2.Inventory"<<endl;
					int c=0;
					cin>>c;
					if (c==1)
					{
						dam=(rand() % W)+1;
						cout<<"You did "<<dam<<" damage"<<endl;
						dam=dam-AB;
						if (dam<0)
							dam=0;
						LB=LB-dam;
						cout<<"The Boss' life now is "<<life<<endl;
						getch();
					}
					else if (c==2)
					{
						if (inv.empty())
						{
							cout<<"You have nothing in the inventory, so you go to attack"<<endl;
							getch();
							dam=(rand() % W)+1;
							cout<<"You did "<<dam<<" damage"<<endl;
							dam=dam-AB;
							if (dam<0)
								dam=0;
							LB=LB-dam;
							cout<<"The Boss' life now is "<<life<<endl;
							getch();
						}
						else
						{
							for (int i=0;i<inv.size();++i)
								cout<<"Your inventory is "<<endl<<i+1 <<") "<<inv.at(i)<<endl;
							cout<<"Which one would you like to take?"<<endl;
							int g;
							cin>>g;
							HP=HP+inv[g-1];
							inv.erase(inv.begin()+g);
							cout<<"Your life now  is "<<HP<<endl;
							getch();
						}
					}
					dam=(rand() % WB)+1;
					cout<<"You got "<<dam<<" damage"<<endl;
					dam=dam-AC;
					if (dam<0)
						dam=0;
					HP=HP-dam;
					cout<<"Your life now is "<<HP<<endl;
					getch();
				}
				else
					cout<<"You got a tie, so you roll again"<<endl;
			}
			if (HP<=0)
			{
				cout<<"Unfortunately you lost the game, so YOU DIED!"<<endl;
				exit(0);
			}
			else 
			{
				while(LB<=0 && HP<=0)
				{
					cout<<"The Boss has been in SUPER POWER mode. And it has new stats now!"<<endl;
					LB=60;
					AB=6;
					WB=12;
					int x,y,i;
					system("cls");
					cout<<"You will roll both a dice. The one with the bigger number plays first"<<endl;
					getch();
					x=(rand() % 6)+1;
					cout<<"You got "<<x<<endl;
					y=(rand() % 6)+1;
					cout<<"The Boss got "<<y<<endl;
					if (x>y)
					{
						cout<<"You got higher so you play first"<<endl;
						getch();
						i=2;
					}
					else if (y>x)
					{
						cout<<"You got lower so you play second"<<endl;
						getch();
						i=1;
					}
					else 
					{
						cout<<"You got tie so you will roll it again"<<endl; 
						i=3;
					}
					if (i==1)
					{
						dam=(rand() % WB)+1;
						cout<<"You got "<<dam<<" damage"<<endl;
						dam=dam-AC;
						if (dam<0)
							dam=0;
						HP=HP-dam;
						cout<<"Your life now is "<<HP<<endl;
						getch();
						cout<<"It's your turn. You have 2 options. Press :"<<endl<<"1.Attack"<<endl<<"2.Inventory"<<endl;
						int c=0;
						cin>>c;
						if (c==1)
						{
							dam=(rand() % W)+1;
							cout<<"You did "<<dam<<" damage"<<endl;
							dam=dam-AB;
							if (dam<0)
								dam=0;
							LB=LB-dam;
							cout<<"The Boss' life now is "<<life<<endl;
							getch();
						}
						else if (c==2)
						{
							if (inv.empty())
							{
								cout<<"You have nothing in the inventory, so you go to attack"<<endl;
								getch();
								dam=(rand() % W)+1;
								cout<<"You did "<<dam<<" damage"<<endl;
								dam=dam-AB;
								if (dam<0)
									dam=0;
								LB=LB-dam;
								cout<<"The Boss' life now is "<<life<<endl;
								getch();
							}
							else
							{
								for (int i=0;i<inv.size();++i)
									cout<<"Your inventory is "<<endl<<i+1 <<") "<<inv.at(i)<<endl;
								cout<<"Which one would you like to take?"<<endl;
								int g;
								cin>>g;
								HP=HP+inv[g-1];
								inv.erase(inv.begin()+g);
								cout<<"Your new life is "<<HP<<endl;
								getch();
							}
						}
					}
					else if (i==2)
					{
						cout<<"It's your turn. You have 2 options. Press :"<<endl<<"1.Attack"<<endl<<"2.Inventory"<<endl;
						int c=0;
						cin>>c;
						if (c==1)
						{
							dam=(rand() % W)+1;
							cout<<"You did "<<dam<<" damage"<<endl;
							dam=dam-AB;
							if (dam<0)
								dam=0;
							LB=LB-dam;
							cout<<"The Boss' life now is "<<life<<endl;
							getch();
						}
						else if (c==2)
						{
							if (inv.empty())
							{
								cout<<"You have nothing in the inventory, so you go to attack"<<endl;
								getch();
								dam=(rand() % W)+1;
								cout<<"You did "<<dam<<" damage"<<endl;
								dam=dam-AB;
								if (dam<0)
									dam=0;
								LB=LB-dam;
								cout<<"The Boss' life now is "<<life<<endl;
								getch();
							}
							else
							{
								for (int i=0;i<inv.size();++i)
									cout<<"Your inventory is "<<endl<<i+1 <<") "<<inv.at(i)<<endl;
								cout<<"Which one would you like to take?"<<endl;
								int g;
								cin>>g;
								HP=HP+inv[g-1];
								inv.erase(inv.begin()+g);
								cout<<"Your life now  is "<<HP<<endl;
								getch();
							}
						}
						dam=(rand() % WB)+1;
						cout<<"You got "<<dam<<" damage"<<endl;
						dam=dam-AC;
						if (dam<0)
							dam=0;
						HP=HP-dam;
						cout<<"Your life now is "<<HP<<endl;
						getch();
					}
					else
						cout<<"You got a tie, so you roll again"<<endl;
				}
			}
			if (HP<=0)
			{
				cout<<"Unfortunately you lost the game, so YOU DIED!"<<endl;
				exit(0);
			}
			else if (life<=0)
			{
				cout<<"You beat the BOSS. Congratulations! You finished the game!"<<endl;
				exit(0);
			}
		}
};


void show(char m[22][82])
{
	for (int i=0;i<22;++i)
	{
		for(int j=0; j<82;++j)
		{
			cout<<m[i][j];
		}
		cout<<endl;
	}
}
void fill(char m[22][82],int rows[])
{
	for (int i=0;i<22;++i)
	{
	    for(int j=0; j<82;++j)
	    {
			m[i][j]= ' ';
			if (i==0)
				m[i][j]='=';
			else if (i==21)
				m[i][j]='=';
			if (j==0)
				m[i][j]='#';
			else if (j==81)
				m[i][j]='#';			
		}
	}
	int a=0,b=1;
	while (rows[a]!=0){
		if (rows[a]==-1)
			{
				b++;
				a++;
			}	
		m[b][rows[a]]='|';
		a++;
	}
    m[1][1]='X';
    m[18][1]='E';
    m[5][45]='E';
    m[9][79]='E';
    m[20][1]='C';
    m[5][47]='C';
    m[11][79]='C';
    m[17][18]='H';
    m[6][30]='H';
    m[17][66]='H';
    m[20][80]='B';
}

int main() 	
	{
	int rows[] = {3,8,13,15,23,29,30,31,35,36,37,38,42,43,48,52,53,54,61,66,67,68,73,78,79,80,-1
	,1,3,6,8,9,11,15,17,18,21,22,23,24,25,27,29,33,37,38,40,42,45,46,48,50,52,56,58,59,61,63,64,68,70,71,75,76,-1
	,1,3,4,6,9,11,12,13,15,17,18,20,27,29,31,32,35,36,40,42,44,45,46,50,52,554,55,58,59,64,65,66,70,73,74,77,78,79,-1
	,1,6,7,9,13,20,22,23,24,26,27,31,32,34,35,36,38,39,40,42,46,47,49,50,54,55,57,61,62,67,67,69,70,72,73,-1
	,1,2,3,4,5,6,9,11,13,14,15,17,19,20,24,28,30,31,32,36,38,39,40,42,43,44,48,52,54,55,56,57,58,59,60,61,62,63,64,65,72,73,75,76,77,79,80,-1
	,4,8,11,13,15,17,21,22,24,25,26,28,29,32,33,34,36,40,44,46,47,48,50,52,54,60,61,66,67,69,70,71,72,76,77,-1
	,2,4,7,10,11,17,19,21,24,26,30,32,36,37,38,40,41,42,44,46,50,52,53,54,56,57,58,60,61,63,64,66,69,70,74,78,79,-1
	,2,4,5,7,9,10,11,12,13,14,15,16,20,21,23,27,28,30,32,34,40,44,46,48,49,50,54,58,63,66,68,69,70,72,74,75,76,78,79,-1
	,2,11,16,18,20,23,26,30,32,36,37,38,39,40,42,43,44,46,48,49,51,52,54,56,58,59,60,61,62,63,65,70,72,76,-1
	,3,4,5,6,7,8,9,11,13,14,18,20,22,23,24,26,28,29,30,32,33,34,35,40,46,50,52,54,56,60,62,63,65,66,67,68,70,72,73,74,76,78,79,-1
	,1,3,7,11,15,18,22,23,24,26,32,33,34,35,37,38,40,41,42,44,45,46,47,48,50,52,54,55,56,57,58,60,63,68,74,76,78,-1
	,5,7,9,10,11,12,13,15,16,17,19,20,21,23,27,28,29,31,32,37,38,42,43,48,50,52,57,58,60,63,64,65,66,68,69,70,71,72,79,-1
	,2,4,5,7,9,10,11,12,15,16,25,26,31,32,34,35,36,37,39,40,42,43,45,46,48,50,53,54,55,57,58,60,66,71,72,73,74,75,76,77,78,-1
	,2,3,5,7,12,18,19,21,23,24,28,29,30,31,32,35,37,40,42,43,45,46,50,51,53,54,55,60,62,63,64,66,67,68,69,71,78,80,-1
	,5,8,9,10,14,15,16,19,22,26,27,28,32,33,35,39,40,45,48,49,55,56,57,58,59,62,63,66,67,71,73,74,75,76,78,80,-1
	,1,2,7,9,10,11,12,13,17,19,20,22,24,25,26,30,33,35,36,37,40,41,42,43,44,47,51,52,53,55,60,63,65,66,67,69,70,71,75,76,78,-1
	,4,6,7,11,15,19,20,22,26,28,29,30,32,33,38,40,41,42,46,47,48,49,51,52,53,55,57,58,60,61,63,67,72,73,75,76,79,-1
	,2,6,7,8,9,13,14,15,16,17,19,22,23,24,26,31,32,33,34,35,36,38,41,42,44,46,47,51,55,58,61,63,64,65,67,68,69,70,72,73,75,77,79,80,-1
	,2,4,5,9,11,13,17,19,21,24,26,27,28,29,34,35,36,38,39,41,44,47,49,50,51,53,54,55,56,58,59,61,63,67,68,70,75,77,79,-1,
	2,7,11,15,19,24,31,32,38,39,43,44,45,49,50,51,58,59,63,64,65,71,72,73,74,77,0};
	char m[22][82];
	srand(time(0));
	hero hrwas;
	boss boss1;
	monster enemy;
	hrwas.getname();
	fill(m,rows);
	int x,y;
	x=y=1;
	show(m);
	char c;
	do{      
	    c=getch();
	    switch(c)
	    {
	        case 'w':
				if (m[x-1][y]==' ')
				{
					m[x][y]=' ';
		            x--;
		            m[x][y]='X';
	        	}
	        	else if (m[x-1][y]=='H')
		        {
		        	m[x][y]=' ';
		            x--;
		            m[x][y]='X';
		            hrwas.getlife();
		        }
		        else if (m[x-1][y]=='C')
		        {
		        	m[x][y]=' ';
		            x--;
		            m[x][y]='X';
		            hrwas.getchest();
		        }
		        else if (m[x-1][y]=='E')
		        {
		        	m[x][y]=' ';
		            x--;
		            m[x][y]='X';
		            enemy.match();
				}
	        	else 
	        	{ break;
				}
	            break;
	        case 's':	
				if (m[x+1][y]==' ')
				{
					m[x][y]=' ';
		            x++;
		            m[x][y]='X';
		        }
		        else if (m[x+1][y]=='H')
		        {
		        	m[x][y]=' ';
		            x++;
		            m[x][y]='X';
		            hrwas.getlife();
		        }
		        else if (m[x+1][y]=='C')
		        {
		        	m[x][y]=' ';
		            x++;
		            m[x][y]='X';
		            hrwas.getchest();
		        }
		        else if (m[x+1][y]=='E')
		        {
		        	m[x][y]=' ';
		            x++;
		            m[x][y]='X';
		            enemy.match();
		        }
		        else 
	        	{ break;
				}
	            break;
	        case 'a':
				if (m[x][y-1]==' ')
				{
					m[x][y]=' ';
		            y--;
		            m[x][y]='X';
		        }
		        else if (m[x][y-1]=='H')
		        {
		        	m[x][y]=' ';
		            y--;
		            m[x][y]='X';
		            hrwas.getlife();
		        }
		        else if (m[x][y-1]=='C')
		        {
		        	m[x][y]=' ';
		            y--;
		            m[x][y]='X';
		            hrwas.getchest();
		        }
		        else if (m[x][y-1]=='E')
		        {
		        	m[x][y]=' ';
		            y--;
		            m[x][y]='X';
		            enemy.match();
		        }
		        else 
	        	{ break;
				}
	            break;
	        case 'd':
				if (m[x][y+1]==' ')
				{
					m[x][y]=' ';
		            y++;
		            m[x][y]='X';
		        }
		        else if (m[x][y+1]=='H')
		        {
		        	m[x][y]=' ';
		            y++;
		            m[x][y]='X';
		            hrwas.getlife();
		        }
		        else if (m[x][y+1]=='C')
		        {
		        	m[x][y]=' ';
		            y++;
		            m[x][y]='X';
		            hrwas.getchest();
		        }
		        else if (m[x][y+1]=='E')
		        {
		        	m[x][y]=' ';
		            y++;
		            m[x][y]='X';
		            enemy.match();
		        }
		        else if (m[x][y+1]=='B')
		        {
		        	m[x][y]=' ';
		            y++;
		            m[x][y]='X';
		            boss1.match1();
		        }
		        else 
	        	{ 	
					break;
				}
	            break;
	        case 'i':
	        	hrwas.inventory();
	    }
	    system("cls");
		show(m);
		   
	}while (true);
	return 0;
	}
	
	
	
	
	
	
	
	
