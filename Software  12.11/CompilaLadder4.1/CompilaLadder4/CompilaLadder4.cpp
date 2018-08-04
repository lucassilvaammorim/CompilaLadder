

// C++.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <fstream>
#include <time.h>
#include <windows.h>
#include <Windows.h>
#include "ControlesDaTela.cpp"
#include <conio.h>
#include <string>
#include <stdlib.h>
#include <sql.h>
#include <sstream>

#define IDC_MAIN_BUTTON	101	// Button identifier
#define IDC_MAIN_EDIT	102


using namespace std;

// 0xc4 representa linha
// 0xb4 representa começo do contato
// 32 representa meio do contato aberto
// 1 representa meio do contato fechado
// 4 representa final do contato
// 5 representa o inicio do paralelo
// 6 representa a parte de baixo do começo do paralelo 
// 7 representa a parte de baixo do fim do paralelo 
// '8' representa a parte de cima do fim do paralelo
// 11 representa as barras do ladder
// 0xb3 representa a linha vertical do fecha paralelo

//A PARTIR DESTA LINHA SÓ DEUS SABE COMO ESSE PROGRAMA FUNCIONA,NÃO ALTERAR NADA,NÃO OFENDER,POIS É BEM PROVÁVEL QUE ESTE PROGRAMA TENHA UMA INTELIGÊNCIA ARTIFICIAL!!!
void mouse();
void Localizar();
void tecla();
void tecla2();
void Apagar(int elemento);
void nova_linha();
void contato_aberto();
void contato_fechado();
void abre_paralelo();
void fecha_paralelo();
void teste();
void empurra_vertical(void);
void desenhar(int linha);
void apaga_network(int net);
void saida(void);
void compilar(int limiteLinha);
void apagar_antiga_marcacao();
void preencher_nova_marcacao();
int verifica_buffer(char tipo);//verificar protocolo
bool verifica_ponto();
int localiza_ponto();
LRESULT CALLBACK WinProc(HWND hWnd, UINT message, WPARAM wParam, LPARAM lParam);
void zera_buffer();
bool segure_contato();
void grava_buffer(int x, int y, char* text);
void grava_matriz(string texto);
void alocacao();
void desenha_buffer(int linha);
void open_project();
bool verifica_bit(int ponto);
bool save();
void load();



//FUNÇOES DO COMPILADOR********************
void funcao_paralelo();
void funcao_principal();
string escreve_path(string startup_path, string file_name);
//*****************************************
string cmdtxt;//endereço do arquivo txt A
string flagtxt;//endereço do arquivo txt d
string desenhotxt; // escreve no arquivo txt da matriz
string serialtxt;
string protocolotxt;
string EXP;


COORD pos_paralelo = { 0, 0 };//indica a posição do ultimo paralelo
COORD aux_mouse = { 0, 0 };
COORD pos = { 0, 0 };//posição do cursor
COORD pos_apaga = { 0, 0 };// variavel de controle para uma situação especifica do apaga, é a coordenada do complemento do paralelo



int matriz_desenho[9999][80]; // matriz onde os caracteres desenhados são guardados e/ou alterados
int numeroNovaLinha = 0; // numero da quantidade de networks
int aux = 0; // variavel de apoio
int network = 1;// valor da network atual do programa
int posy_aux = 0;// variavel de auxilio da linha limite do paralelo, seja ele o que abre ou fecha
int LimiteMax = 9998, LimiteMin = 1; // setam os limites pelo qual o cursos pode se deslocar, quando um paralelo esta sendo feito estes são alterados. 
int espaco_paralelo = -1;// variavel usada para setar a distancia minima entre o inicio e o fim do paralelo, atualmente é a distancia do contato
int numeroLinhaFinal = 0;
int linhabuffer = 0;
int colunaEXP = 0;


//VARIAVEIS DO COMPILADOR**********************
int linhaCompila = 0, colunaCompila = 0;
int numeroParalelo2 = 0;
int numeroParalelo4 = 0;
int colunaVolta[50], linhaVolta[50];
int colunaVolta_aux = 0;
int matriz[16][80];
int matriz_protocolo[9999][80];
char **matriz_otmizada;
int indiceParalelos = 0;
int net = 0; //variavel auxiliar de networks para o compilar
int flag = 0;//verifica se há uma informação nova no txt
int aux_buffer;//usado para memórias
bool flag_mem = false;

bool flagDois = false;
bool flagParaleloCompila = false;
bool flag_volta = false; //on ou off
bool flagLinhaVazia = true;
bool flagContato = false;
bool LinhaEncontrada = false;
//bool flagIncColuna = true; // começa tentando ligar
//int  colunaVolta = -1;// linhaCompila e colunaCompila para retornar em caso de paralelo *SUJEITO À MUDANÇA DE VALORES*
//*********************************************

bool flag_paralelo = false;// indica se o paralelo precisa fechar ou não
bool flag1 = false; // permite que o paralelo da esquerda possa ser reposicionado.
bool flag5_8 = false; // é setada quando ao apagar um paralelo ela encontra um 5 ou um 8 na matriz
bool flag_sintaxe = false;
bool flag5 = false;
char Tecla = 0;
string Tecla2;
char buffer[20];
string matriz_buffer[9999][80];


//Variaveis text box ***************************************************************

HWND hwndConsole;// = FindWindowA( NULL, title);
HINSTANCE hInst; // = (HINSTANCE)GetWindowLong(hwndConsole, GWL_HINSTANCE);
WNDCLASSEX wClass;
char title[500];
HWND hEdit;
HWND hWnd;

int main(int argc, char * argv[])
{
	

	zera_buffer();
	for (int i = 0; i < 999; i++)
	{
		for (int l = 0; l < 80; l++)
		{

			VaiParaXY(l, i); printf(" "); Cor(0xf0);
			matriz_desenho[i][l] = 0;
			matriz_protocolo[i][l] = 0xff;
			matriz_buffer[i][l] = "x";

		}

	}

	string l = argv[0];
	flagtxt = escreve_path(l, "flag.txt");
	cmdtxt = escreve_path(l, "cmd.txt");
	desenhotxt = escreve_path(l, "desenho.txt");
	protocolotxt = escreve_path(l, "protocolo.txt");
	serialtxt = escreve_path(l, "serial.txt");


	VaiParaXY(0, 1);


	//criando message box ***********************************************************************************************************************
	hwndConsole = FindWindow(NULL, title);
	hInst = (HINSTANCE)GetWindowLong(hwndConsole, GWL_HINSTANCE);
	GetConsoleTitleA(title, 500);
	ZeroMemory(&wClass, sizeof(WNDCLASSEX));
	wClass.cbClsExtra = NULL;
	wClass.cbSize = sizeof(WNDCLASSEX);
	wClass.cbWndExtra = NULL;
	wClass.hbrBackground = (HBRUSH)COLOR_WINDOW;
	wClass.hCursor = LoadCursor(NULL, IDC_ARROW);
	wClass.hIcon = NULL;
	wClass.hIconSm = NULL;
	wClass.hInstance = hInst;
	wClass.lpfnWndProc = (WNDPROC)WinProc;
	wClass.lpszClassName = "Window Class";
	wClass.lpszMenuName = NULL;
	wClass.style = CS_HREDRAW | CS_VREDRAW;

	if (!RegisterClassEx(&wClass))
	{
		int nResult = GetLastError();
		MessageBox(NULL, "Window class creation failed\r\n", "Window Class Failed", MB_ICONERROR);
	}

	//***********************************************************************************************************************************************************************


	while (1)
	{
		ifstream reader(flagtxt);
		reader >> flag;
		reader.close();//LE A FLAG PARA VERIFICAR SE HA NOVA INFORMAÇÃO

		if (flag)
		{
			ifstream reader(cmdtxt);
			reader >> Tecla2;
			reader.close();//LE O BOTAO APERTADO NO SOFTWARE

			ofstream writer(flagtxt);
			writer << "0";
			writer.close();
			flag = 0;//RESETA A FLAG

			tecla2();


		}
		else if (_kbhit())
		{
			tecla();
		}
		else if (!_kbhit())
		{
			mouse();

		}
	}
}
#pragma region DesenhaLadder
void Localizar()//le matricialmente a posição atual do cursor
{
	pos.X = LePosicaoX();
	pos.Y = LePosicaoY();
}
void tecla()//mov cursor
{
	int var = 0;
	Localizar();
	Tecla = _getch();
	switch (Tecla)
	{

	case 72://move up
		apagar_antiga_marcacao();
		if (pos.Y > LimiteMin)	VaiParaXY(pos.X, (pos.Y - 1));
		if (matriz_desenho[pos.Y - 1][pos.X] == 0xcd)
		{
			network--;
			VaiParaXY(pos.X, (pos.Y - 2));
		}
		Localizar();
		preencher_nova_marcacao();

		break;


	case 80://mov down
		apagar_antiga_marcacao();
		if (pos.Y <= LimiteMax)
		{
			VaiParaXY(pos.X, (pos.Y + 1));
			if (matriz_desenho[pos.Y + 1][pos.X] == 0xcd)
			{
				network++;
				VaiParaXY(pos.X, (pos.Y + 2));
			}
		}
		Localizar();
		preencher_nova_marcacao();

		break;

	case 77://move right
		apagar_antiga_marcacao();
		if (pos.X <= 75)VaiParaXY((pos.X + 1), pos.Y);
		Localizar();
		preencher_nova_marcacao();
		break;

	case 75://move left
		apagar_antiga_marcacao();
		if (pos.X > 1)VaiParaXY((pos.X - 1), pos.Y);

		Localizar();
		preencher_nova_marcacao();

		break;
	case 49:  // nova linha, botão "1"
		nova_linha();
		break;
	case 50:   // contato aberto , botão "2"
		contato_aberto();
		break;
	case 51:   // contato fechado , botão "3"
		contato_fechado();
		break;
	case 52: // abre paralelo , botão 4
		if (numeroNovaLinha != 0)
		{
			abre_paralelo();
		}

		break;
	case 53: // fecha paralelo, botao 5
		if (numeroNovaLinha != 0 && flag_paralelo == true)
		{
			fecha_paralelo();
		}

		break;
	case 83: //apagar (botao Delete)
		Apagar(matriz_desenho[pos.Y][pos.X]);
		break;
	case 32: // espaço
		teste();
		break;
/*	case 'f':    //procura network

		VaiParaXY(12, ((network - 1) * 18));
		printf("Digite a network que voce deseja ir: ");
		scanf_s("%d", &var);
		if (var == 0 || var > 556 || var > (numeroNovaLinha))
		{
			VaiParaXY(12, ((network - 1) * 18));
			printf("                                        ");
			VaiParaXY(12, ((network - 1) * 18));
			printf("Erro");
			_getch();
			VaiParaXY(12, ((network - 1) * 18));
			printf("    ");
			break;
		}

		else
		{

			VaiParaXY(12, ((network - 1) * 18));
			printf("                                        ");
			VaiParaXY(12, ((var - 1) * 18));
			network = var;
		}

		break;*/
	case 54:   // botão 6 //coloca saida
		saida();

		break;
	case 'n': // apaga network
		apaga_network(network);
		break;

	case 'c'://compila o desenho
		compilar(numeroNovaLinha);
		break;
	case 's':
		save();
		break;
	case 'l':
		load();
		break;

	}

}
void tecla2()//desenha a parit do txt lido
{
	int var = 0;
	Localizar();

	if (Tecla2 == "nn")nova_linha();

	else if (Tecla2 == "ca")contato_aberto();

	else if (Tecla2 == "cf")contato_fechado();

	else if (Tecla2 == "ap")
	{
		if (numeroNovaLinha != 0)abre_paralelo();

	}

	else if (Tecla2 == "fp")
	{
		if (numeroNovaLinha != 0)
		{
			fecha_paralelo();
		}

	}

	else if (Tecla2 == "sa") saida();
	else if (Tecla2 == "Co") compilar(numeroNovaLinha);
	else if (Tecla2 == "de") apaga_network(network);
	else if (Tecla2.substr(0, 2) == "fn")
	{

		var = (char)Tecla2[2] - 48;
		if (var == 0 || var > 556 || var > (numeroNovaLinha))
		{
			MessageBox(NULL, "NETWORK NÂO ENCONTRADA", "Erro", MB_ICONERROR);

		}
		else
		{
		
			VaiParaXY(12, ((network - 1) * 18));
			printf("                                        ");
			VaiParaXY(12, ((var - 1) * 18));
			network = var;

		}

	}
	else if (Tecla2 == "l")
	{
		load();	
	}
	else if(Tecla2 == "k")
	{
		save();
	}


}
void Apagar(int elemento)
{
	int linhaTemp = pos.Y;
	int colunaTemp = pos.X;
	int aux = 0, aux2 = 0;
	bool flag_apaga_linha = true;
	if (elemento == 0xc3 || elemento == 0x2f || elemento == 32 || elemento == 0xb4) // apaga contatos, tanto aberto quanto fechado , em qualquer posicao
	{

		while (matriz_desenho[pos.Y][colunaTemp] != 0xb4)
		{
			colunaTemp--;
		}
		for (int i = 5; i > 0; i--)
		{
			if (i > 2)
			{
				VaiParaXY(colunaTemp, pos.Y);
				printf_s("%c", 0xc4);
				VaiParaXY(colunaTemp, pos.Y - 1); printf("  ");
			}

			VaiParaXY(colunaTemp, pos.Y - 1); printf_s("        ");
			VaiParaXY(colunaTemp, pos.Y);
			matriz_desenho[pos.Y][colunaTemp] = 0xc4;
			matriz_protocolo[pos.Y][colunaTemp] = 0x84;
			matriz_buffer[pos.Y][colunaTemp] = "x";
			colunaTemp++;
		}
	}
	/*******************************************************************************************************************************************************************/
	else if (elemento == '6'&& flag1 == false || elemento == '7' && flag_paralelo == false) /**************************************************Apaga os paralelos,todos os casos */
	{
		if ((pos_apaga.X == -1 && pos_apaga.Y == -1) || flag5_8 == false && (pos.X == pos_apaga.X && pos.Y == pos_apaga.Y))

		{
			posy_aux = pos.Y;

			LimiteMax = 15 + ((network - 1) * 18);
			LimiteMin = 1 + ((network - 1) * 18);

			if (elemento == '6')
			{
				if (colunaTemp == 75) return;
				while (matriz_desenho[pos.Y][colunaTemp] != '7')
				{
					if (matriz_desenho[pos.Y][colunaTemp + 1] == '5' || matriz_desenho[pos.Y][colunaTemp + 1] == '8')flag5_8 = true;
					if (matriz_desenho[pos.Y][colunaTemp + 1] == '6')break;
					if (matriz_desenho[pos.Y][colunaTemp + 1] == '7')
					{
						espaco_paralelo = colunaTemp + 1;
						pos_apaga.X = colunaTemp + 1;
						pos_apaga.Y = pos.Y;
						flag1 = true;//flag utilizado para completar a linha com caracteres de linha quando o abre paralelo é reposicionado
						break;
					}
					if (colunaTemp == 79)
					{
						flag1 = false;
						espaco_paralelo = -1;
						break;
					}
					colunaTemp++;

				}
				posy_aux = linhaTemp;
				aux = 1; // desloca pra direita
				flag_paralelo = false;
				aux2 = '7';
			}
			else if (elemento == '7')
			{
				flag1 = false;
				aux2 = '6';
				while (matriz_desenho[pos.Y][colunaTemp] != '6')
				{

					if (matriz_desenho[pos.Y][colunaTemp - 1] == '5' || matriz_desenho[pos.Y][colunaTemp - 1] == '8')flag5_8 = true;
					VaiParaXY(colunaTemp, pos.Y);
					if (matriz_desenho[pos.Y][colunaTemp - 1] == '6')
					{
						espaco_paralelo = colunaTemp - 1;
						pos_apaga.X = colunaTemp - 1;
						pos_apaga.Y = pos.Y;
						flag_paralelo = true;
						break;
					}
					if (colunaTemp < 3) { break; }
					colunaTemp--;

				}

				posy_aux = linhaTemp;
				aux = -1;// desloca para esquerda
			}



			while (matriz_desenho[linhaTemp][colunaTemp] != 0)//***************procura o complemento do paralelo , caso ele nao encontre , ele apaga todo o ramo
			{
				if (matriz_desenho[linhaTemp][colunaTemp] == aux2)
				{
					flag_apaga_linha = false;
				}

				colunaTemp = colunaTemp + aux;
			}
			if (flag_apaga_linha == true)
			{
				//***********************************************************editado dia 24/06, bug ao apagar o paralelo com contatos,e outro bug com o espaço paralelo nao resetando
				while (1)
				{
					if (matriz_desenho[linhaTemp][colunaTemp] == '6' || matriz_desenho[linhaTemp][colunaTemp] == '7' || matriz_desenho[linhaTemp][colunaTemp] == 0xb3) break;//antigamente a ultima condição era 0xc4 24/06
					VaiParaXY(colunaTemp, linhaTemp); printf_s(" ");
					VaiParaXY(colunaTemp - 1, linhaTemp - 1); printf_s(" ");
					matriz_desenho[linhaTemp][colunaTemp] = 0;
					matriz_buffer[linhaTemp][colunaTemp] = "x";
					matriz_protocolo[linhaTemp][colunaTemp] = 255;
					colunaTemp = colunaTemp - aux;

					espaco_paralelo = -1;
				}
				//**********************************************************************************************

				LimiteMax = 9998;
				LimiteMin = 1;
				pos_apaga.X = -1;
				pos_apaga.Y = -1;

			}//********************************************************************************************************************************************
			linhaTemp = pos.Y;
			colunaTemp = pos.X;
			VaiParaXY(colunaTemp, linhaTemp); printf_s(" ");
			matriz_desenho[linhaTemp][colunaTemp] = 0;
			matriz_buffer[linhaTemp][colunaTemp] = "x";
			matriz_protocolo[linhaTemp][colunaTemp] = 255;
			VaiParaXY(colunaTemp, linhaTemp - 1); printf_s(" ");
			while (matriz_desenho[linhaTemp][colunaTemp] != '5' && matriz_desenho[linhaTemp][colunaTemp] != '8')
			{
				linhaTemp--;
				VaiParaXY(colunaTemp, linhaTemp);
			}
			for (int i = pos.Y - 1; i > linhaTemp; i--)
			{
				VaiParaXY(colunaTemp, i); printf_s(" ");
				VaiParaXY(colunaTemp - 1, i); printf_s(" ");
				matriz_desenho[i][colunaTemp] = 0;
				matriz_buffer[i][colunaTemp] = "x";
				matriz_protocolo[i][colunaTemp] = 255;
			}


			if ((matriz_desenho[linhaTemp][colunaTemp] == '5' && linhaTemp == (1 + ((network - 1) * 18)))
				|| matriz_desenho[linhaTemp][colunaTemp] == '5' && matriz_desenho[linhaTemp][colunaTemp + 1] == 0xc4 && matriz_desenho[linhaTemp][colunaTemp - 1] == 0xc4
				|| (matriz_desenho[linhaTemp][colunaTemp] == '8' && linhaTemp == (1 + ((network - 1) * 18)))
				|| matriz_desenho[linhaTemp][colunaTemp] == '8' && matriz_desenho[linhaTemp][colunaTemp + 1] == 0xc4 && matriz_desenho[linhaTemp][colunaTemp - 1] == 0xc4)
			{
				VaiParaXY(colunaTemp, linhaTemp); printf_s("%c", 0xc4);
				VaiParaXY(colunaTemp, linhaTemp - 1); printf(" ");
				matriz_desenho[linhaTemp][colunaTemp] = 0xc4;
				matriz_protocolo[linhaTemp][colunaTemp] = 0x84;
				matriz_buffer[linhaTemp][colunaTemp] = "x";


			}
			else if (matriz_desenho[linhaTemp][colunaTemp] == '5' && linhaTemp != (1 + ((network - 1) * 18)))
			{
				if (matriz_desenho[linhaTemp][colunaTemp - 1] != 0xc4 && matriz_desenho[linhaTemp][colunaTemp - 1] != '6' && matriz_desenho[linhaTemp][colunaTemp - 1] != '5' && matriz_desenho[linhaTemp][colunaTemp - 1] != '8')
				{

					VaiParaXY(colunaTemp, linhaTemp); printf_s("%c", 0xc0);
					matriz_desenho[linhaTemp][colunaTemp] = '6';
					matriz_protocolo[linhaTemp][colunaTemp] = 0x86;
					matriz_buffer[linhaTemp][colunaTemp] = "x";
				}
				else
				{
					VaiParaXY(colunaTemp, linhaTemp); printf_s("%c", 0xc4);
					VaiParaXY(colunaTemp, linhaTemp - 1); printf(" ");
					matriz_desenho[linhaTemp][colunaTemp] = 0xc4;
					matriz_protocolo[linhaTemp][colunaTemp] =  0x84;
					matriz_buffer[linhaTemp][colunaTemp] = "x";
				}

			}
			else if (matriz_desenho[linhaTemp][colunaTemp] == '8' && linhaTemp != (1 + ((network - 1) * 18)))
			{
				if (matriz_desenho[linhaTemp][colunaTemp + 1] != 0xc4 && matriz_desenho[linhaTemp][colunaTemp - 1] != '7' && matriz_desenho[linhaTemp][colunaTemp - 1] != '8' && matriz_desenho[linhaTemp][colunaTemp + 1] != '7')
				{
					VaiParaXY(colunaTemp, linhaTemp); printf_s("%c", 0xd9);
					matriz_desenho[linhaTemp][colunaTemp] = '7';
					matriz_protocolo[linhaTemp][colunaTemp] = 0x87;
					matriz_buffer[linhaTemp][colunaTemp] = "x";
				}
				else
				{
					VaiParaXY(colunaTemp, linhaTemp); printf_s("%c", 0xc4);
					VaiParaXY(colunaTemp, linhaTemp - 1); printf(" ");
					matriz_desenho[linhaTemp][colunaTemp] = 0xc4;
					matriz_protocolo[linhaTemp][colunaTemp] = 0x84;
					matriz_buffer[linhaTemp][colunaTemp] = "x";
				}
			}




			while (matriz_desenho[pos.Y][colunaTemp + aux] == 0xc4)//*******apaga a linha até encontrar um contato
			{

				VaiParaXY(colunaTemp + aux, pos.Y); printf_s(" ");
				VaiParaXY(colunaTemp + aux, pos.Y - 1); printf_s(" ");
				matriz_desenho[pos.Y][colunaTemp + aux] = 0;
				matriz_buffer[pos.Y][colunaTemp + aux] = "x";
				matriz_protocolo[pos.Y][colunaTemp + aux] = 255;
				colunaTemp = colunaTemp + aux;

			}//*************************************************************************************

		}
	}
	else if (elemento == 0x28) //*** apaga saída
	{
		if (linhaTemp == (1 + ((network - 1) * 18)))
		{
			VaiParaXY(colunaTemp - 2, linhaTemp - 1); printf("  ");
			for (int i = 0; i < 5; i++)
			{
				if (i < 3)
				{
					matriz_desenho[linhaTemp][colunaTemp + i] = 0xc4;
					matriz_protocolo[linhaTemp][colunaTemp + i] = 0x84;
					matriz_buffer[linhaTemp][colunaTemp + i] = "x";
					VaiParaXY(colunaTemp + i, linhaTemp); printf("%c", 0xc4);
					VaiParaXY(colunaTemp + i, linhaTemp - 1); printf(" ");
				}

			}
		}

		else
		{
			for (int i = 0; i < 4; i++)
			{
				matriz_desenho[linhaTemp][colunaTemp + i] = 0;
				matriz_protocolo[linhaTemp][colunaTemp + i] = 0xff;
				matriz_buffer[linhaTemp][colunaTemp + i] = "x";
				VaiParaXY(colunaTemp + i, linhaTemp); printf(" ");
				VaiParaXY(colunaTemp + i, linhaTemp - 1); printf(" ");
			}
			if (matriz_desenho[linhaTemp + 1][colunaTemp - 1] == 0xb3)
			{
				matriz_desenho[linhaTemp][colunaTemp - 1] = 0xb3;
				matriz_buffer[linhaTemp][colunaTemp - 1] = "x";
				matriz_protocolo[linhaTemp][colunaTemp - 1] = 255;
				VaiParaXY(colunaTemp - 1, linhaTemp); printf("%c", 0xb3);
				VaiParaXY(colunaTemp - 1, linhaTemp - 1); printf(" ");
			}
			else
			{
				while (matriz_desenho[linhaTemp][colunaTemp - 1] != '5')
				{
					matriz_desenho[linhaTemp][colunaTemp - 1] = 0;
					matriz_buffer[linhaTemp][colunaTemp - 1] = "x";
					matriz_protocolo[linhaTemp][colunaTemp - 1] = 255;
					VaiParaXY(colunaTemp - 1, linhaTemp); printf(" ");
					VaiParaXY(colunaTemp - 1, linhaTemp - 1); printf(" ");
					linhaTemp--;
				}
				if (linhaTemp != (1 + ((network - 1) * 18)))
				{
					matriz_desenho[linhaTemp][colunaTemp - 1] = '6';
					matriz_protocolo[linhaTemp][colunaTemp - 1] = 0x86;
					matriz_buffer[linhaTemp][colunaTemp - 1] = "x";
					VaiParaXY(colunaTemp - 1, linhaTemp); printf("%c", 0xc0);
				}
				else
				{
					matriz_desenho[linhaTemp][colunaTemp - 1] = 0xc4;
					matriz_protocolo[linhaTemp][colunaTemp - 1] = 0x84;
					matriz_buffer[linhaTemp][colunaTemp - 1] = "x";
					VaiParaXY(colunaTemp - 1, linhaTemp); printf("%c", 0xc4);
					VaiParaXY(colunaTemp - 1, linhaTemp - 1); printf(" ");
				}
			}

		}
	}

}

void nova_linha() // cria uma nova network
{
	if (numeroNovaLinha > 554)return;
	VaiParaXY(0, (1 + (numeroNovaLinha * 18))); printf_s("%c", 0xc3);
	matriz_desenho[(1 + (numeroNovaLinha * 18))][0] = 11;

	VaiParaXY(0, (1 + (numeroNovaLinha * 18)) + 16); printf_s("%c", 0xcd);
	matriz_desenho[(1 + (numeroNovaLinha * 18)) + 16][0] = 0xcd;//*

	VaiParaXY(79, (1 + (numeroNovaLinha * 18))); printf_s("%c", 0xB4);
	matriz_desenho[(1 + (numeroNovaLinha * 18))][79] = 11;

	VaiParaXY(79, (1 + (numeroNovaLinha * 18)) + 16); printf_s("%c", 0xcd);
	matriz_desenho[(1 + (numeroNovaLinha * 18)) + 16][79] = 0xcd;//**

	for (int j = 1; j < 79; j++)
	{

		matriz_desenho[(1 + (numeroNovaLinha * 18))][j] = 0xc4; matriz_protocolo[(1 + (numeroNovaLinha * 18))][j] = 0x84;
		VaiParaXY(j, (1 + (numeroNovaLinha * 18))); printf_s("%c", 0xc4);
		matriz_desenho[(1 + (numeroNovaLinha * 18)) + 16][j] = 0xcd; matriz_protocolo[(1 + (numeroNovaLinha * 18)) + 16][j] = 0x84;
		VaiParaXY(j, (1 + (numeroNovaLinha * 18)) + 16); printf_s("%c", 0xcd);
	}
	VaiParaXY(1, (1 + (numeroNovaLinha * 18)));



	network = numeroNovaLinha + 1;

	VaiParaXY(0, (numeroNovaLinha * 18)); printf("Network: %d", network);
	matriz_desenho[(numeroNovaLinha * 18)][0] = 'N';
	matriz_desenho[(numeroNovaLinha * 18) ][1] = 'e';
	matriz_desenho[(numeroNovaLinha * 18)][2] = 't';
	matriz_desenho[(numeroNovaLinha * 18)][3] = 'w';
	matriz_desenho[(numeroNovaLinha * 18)][4] = 'o';
	matriz_desenho[(numeroNovaLinha * 18)][5] = 'r';
	matriz_desenho[(numeroNovaLinha * 18)][6] = 'k';
	matriz_desenho[(numeroNovaLinha * 18)][7] = ':';
	matriz_desenho[(numeroNovaLinha * 18)][8] = ' ';
	matriz_desenho[(numeroNovaLinha * 18)][9] = network;
	numeroNovaLinha++;


}
void contato_aberto() //faz um contato aberto
{
	Localizar();



	if (segure_contato())
	{

		if (matriz_desenho[pos.Y][pos.X - 1] == 0xc3)pos.X++;//  não deixa colocar um contato grudado no outro

		hWnd = CreateWindowEx(NULL, "Window Class", "Endereço da variavel", WS_OVERLAPPEDWINDOW, 100, 100, 200, 120, NULL, NULL, hInst, NULL);

		if (!hWnd)
		{
			int nResult = GetLastError();
			MessageBox(NULL, "Window creation failed\r\n", "Window Creation Failed", MB_ICONERROR);
		}
		ShowWindow(hWnd, 4);
		MSG msg;
		ZeroMemory(&msg, sizeof(MSG));

		while (GetMessage(&msg, NULL, 0, 0))
		{
			TranslateMessage(&msg);
			DispatchMessage(&msg);
		}



		matriz_protocolo[pos.Y][pos.X] = verifica_buffer(0x50);
		matriz_buffer[pos.Y][pos.X] = buffer;





		if (flag_mem)
		{
			matriz_protocolo[pos.Y][pos.X + 1] = aux_buffer;
			flag_mem = false;

		}

		if (buffer[0] == NULL || flag_sintaxe == true)
		{

			MessageBox(NULL, "ERRO DE SÍNTAXE", "Erro", MB_ICONERROR);
			flag_sintaxe = false;
			return;
		}

		VaiParaXY(pos.X, pos.Y); printf_s("%c", 0xB4);
		matriz_desenho[pos.Y][pos.X] = 0xb4;


		VaiParaXY(pos.X + 1, pos.Y); printf_s("%c", 0x20);
		matriz_desenho[pos.Y][pos.X + 1] = 0x20;

		VaiParaXY(pos.X + 2, pos.Y); printf_s("%c", 0xc3);
		matriz_desenho[pos.Y][pos.X + 2] = 0xc3;


		//VaiParaXY(pos.X, pos.Y - 1); printf_s("%d", matriz_protocolo[pos.Y][pos.X]);
		//VaiParaXY(pos.X + 5, pos.Y - 1); printf_s("%d", matriz_protocolo[pos.Y][pos.X + 1]);
		if (matriz_buffer[pos.Y][pos.X] != " ")
		{
			VaiParaXY(pos.X, pos.Y - 1); cout << matriz_buffer[pos.Y][pos.X];
		}


		VaiParaXY(pos.X + 3, pos.Y);





	}
	apagar_antiga_marcacao();
	Localizar();
	preencher_nova_marcacao();
	zera_buffer();



}
void contato_fechado() // faz um contato fechado
{
	Localizar();
	if (matriz_desenho[pos.Y][pos.X - 1] == 0xc3)pos.X++; // não permitir que o contato fique grudado um ao outro




	if (segure_contato())
	{
		hWnd = CreateWindowEx(NULL, "Window Class", "Endereço da variavel", WS_OVERLAPPEDWINDOW, 100, 100, 200, 120, NULL, NULL, hInst, NULL);

		if (!hWnd)
		{
			int nResult = GetLastError();
			MessageBox(NULL, "Window creation failed\r\n", "Window Creation Failed", MB_ICONERROR);
		}
		ShowWindow(hWnd, 4);
		MSG msg;
		ZeroMemory(&msg, sizeof(MSG));

		while (GetMessage(&msg, NULL, 0, 0))
		{
			TranslateMessage(&msg);
			DispatchMessage(&msg);
		}

		matriz_protocolo[pos.Y][pos.X] = verifica_buffer(0x40);
		
			matriz_buffer[pos.Y][pos.X] = buffer;

		if (flag_mem)
		{
			matriz_protocolo[pos.Y][pos.X + 1] = aux_buffer;
			flag_mem = false;

		}
		if (buffer[0] == NULL || flag_sintaxe == true)
		{

			MessageBox(NULL, "ERRO DE SÍNTAXE", "Erro", MB_ICONERROR);
			flag_sintaxe = false;
			return;
		}


		VaiParaXY(pos.X, pos.Y); printf_s("%c", 0xB4);
		matriz_desenho[pos.Y][pos.X] = 0xb4;


		VaiParaXY(pos.X + 1, pos.Y); printf_s("%c", 0x2f);
		matriz_desenho[pos.Y][pos.X + 1] = 0x2f;

		VaiParaXY(pos.X + 2, pos.Y); printf_s("%c", 0xc3);
		matriz_desenho[pos.Y][pos.X + 2] = 0xc3;

		//VaiParaXY(pos.X, pos.Y - 1); printf_s("%d", matriz_protocolo[pos.Y][pos.X]);
		//VaiParaXY(pos.X + 6, pos.Y - 1); printf_s("%d", matriz_protocolo[pos.Y][pos.X + 1]);
		if (matriz_buffer[pos.Y][pos.X] != "x")
		{
			VaiParaXY(pos.X, pos.Y - 1); cout << matriz_buffer[pos.Y][pos.X];
		}

		VaiParaXY(pos.X + 3, pos.Y);
	}
	apagar_antiga_marcacao();
	Localizar();
	preencher_nova_marcacao();
	zera_buffer();
}
void abre_paralelo() // abre um paralelo
{
	int colunaTemp = pos.X, linhatemp = pos.Y; // variaveis auxiliares da posição do cursor
	if (espaco_paralelo != -1 && pos.X > (espaco_paralelo - 4))return; // caso ã area onde o pararalelo for abrir não siga o limite minimo de espaço
	if (matriz_desenho[pos.Y][pos.X] == '7')pos.X += 2;// não deixar começar um paralelo exatamente onde outro termina

	else if (matriz_desenho[pos.Y - 1][pos.X] == '6' || matriz_desenho[pos.Y - 1][pos.X] == 0xc4) // espaço horizontal entre um paralelo e outro
	{
		if (matriz_desenho[pos.Y][pos.X] != 0 || matriz_desenho[pos.Y + 1][pos.X] != 0 || matriz_desenho[pos.Y + 2][pos.X] != 0)empurra_vertical();
		pos.Y++;
	}
	else if (matriz_desenho[pos.Y][pos.X] == '6' || matriz_desenho[pos.Y][pos.X] == 0xc4) // espaço horizontal entre um paralelo e outro
	{
		if (matriz_desenho[pos.Y + 1][pos.X] != 0 || matriz_desenho[pos.Y + 2][pos.X] != 0 || matriz_desenho[pos.Y + 3][pos.X] != 0)empurra_vertical();
		pos.Y += 2;
	}


	if (flag1 == true) // completa com linha o resto, é usado somente quando o paralelo da esquerda é reposicionado pelo usuario

	{
		while (1)
		{
			if (matriz_desenho[posy_aux][pos.X - 1] == '7')return;
			else if (matriz_desenho[posy_aux][colunaTemp] == '7')break;
			else if (matriz_desenho[posy_aux][colunaTemp] == '6' || colunaTemp == 79 || matriz_desenho[posy_aux][colunaTemp] == 0xb3)return;
			colunaTemp++;
		}
		pos.Y = posy_aux;


		aux = pos.X + 1;
		while (matriz_desenho[pos.Y][aux] == 0)
		{
			aux++;
		}
		for (int i = pos.X + 1; i < aux; i++)
		{
			matriz_desenho[pos.Y][i] = 0xc4; matriz_protocolo[pos.Y][i] = 0x84;
			VaiParaXY(i, pos.Y); printf_s("%c", 0xc4);
		}
		aux = 0;

	}

	if (pos.Y > 2 && flag_paralelo == false && matriz_desenho[pos.Y][pos.X] != 0xc4) // mais segurança para poder abrir o paralelo
	{
		while (matriz_desenho[pos.Y - aux][pos.X] != 0xc4 && matriz_desenho[pos.Y - aux][pos.X] != '6' /*&& matriz_desenho[pos.Y - aux][pos.X] != '7'*/)
		{
			if ((pos.Y - aux) < 0){ break; }
			if (matriz_desenho[pos.Y - aux][pos.X] != 0xc4 && matriz_desenho[pos.Y - aux][pos.X] != 0)
			{
				aux = 0;
				return;
			}
			aux++;
		}


		if ((pos.Y - aux) <= 0){ aux = 0; }

		posy_aux = pos.Y - 1;
		if (matriz_desenho[pos.Y - aux][pos.X] != '6')
		{
			VaiParaXY(pos.X, pos.Y - aux); printf_s("%c", 0xc2);
		}
		else
		{
			VaiParaXY(pos.X, pos.Y - aux); printf_s("%c", 0xc3);
		}
		flag_paralelo = true;
		if (flag1 == true)
		{
			flag1 = false;
			flag_paralelo = false;
		}

		matriz_desenho[pos.Y - aux][pos.X] = '5'; matriz_protocolo[pos.Y - aux][pos.X] = 0x85;//verifique o protocolo
		VaiParaXY(pos.X, pos.Y); printf_s("%c", 0xc0);
		matriz_desenho[pos.Y][pos.X] = '6'; matriz_protocolo[pos.Y][pos.X] = 0x86;//verifique o proocolo
		while (matriz_desenho[posy_aux][pos.X] != '5' && matriz_desenho[posy_aux][pos.X] != 0xc4)
		{
			VaiParaXY(pos.X, posy_aux);
			printf_s("%c", 0xb3);
			matriz_desenho[posy_aux][pos.X] = 0xb3;
			posy_aux--;
		}
		posy_aux = pos.Y;
		colunaTemp = pos.X;
		aux = 0;


	}



	pos_apaga.X = -1;
	pos_apaga.Y = -1;
	LimiteMax = 15 + ((network - 1) * 18);
	LimiteMin = 1 + ((network - 1) * 18);

	while (colunaTemp <80)//***************procura o complemento do paralelo , caso ele  encontre , ele resseta os limites para o valor de default 
	{
		if (matriz_desenho[pos.Y][colunaTemp] == '7')
		{
			LimiteMax = 9998;
			LimiteMin = 1;
			flag5_8 = false;
			break;
		}


		colunaTemp++;
	}

	if (espaco_paralelo == -1)espaco_paralelo = pos.X;
	else if (espaco_paralelo != -1)espaco_paralelo = -1;
	apagar_antiga_marcacao();
	VaiParaXY(pos.X, pos.Y);
	Localizar();
	preencher_nova_marcacao();



}
void fecha_paralelo() // fecha um paralelo
{
	int colunaTemp = pos.X, linhaTemp = posy_aux; // variaveis auxiliares da posição do cursor

	if (matriz_desenho[linhaTemp][colunaTemp] != 0)return;  // posição onde não pode fechar o paralelo, pois há outro elemento no lugar
	if (espaco_paralelo != -1 && pos.X < (espaco_paralelo + 4))return; // caso a area onde vc quer fechar o paralelo não esteja dentro do limite minimo estabelecido
	while (linhaTemp != (1 + ((network - 1) * 18)))//analisa de baixo pra cima ate a linha principal da network atual
	{
		if (matriz_desenho[linhaTemp][colunaTemp] == '6' || linhaTemp < (1 + ((network - 1) * 18)))return; // impede que um paralelo seja fechado exatamente onde outro começa
		//if (linhaTemp == (1 + ((network - 1) * 18)))break;
		//if (linhaTemp == ((network - 1) * 18))return;
		linhaTemp--;
	}

	while (matriz_desenho[posy_aux][colunaTemp] == 0)
	{
		if (matriz_desenho[posy_aux][colunaTemp - 1] == '7' || colunaTemp == 0 || matriz_desenho[posy_aux][colunaTemp - 1] == 0xb3)return; //caso ele encontre na mesma linha que ele outro caracter fechado ele deve parar
		//MUDEI ESSE IF AQUI 24/06 /\


		//else if (matriz_desenho[posy_aux][colunaTemp] != 0)break;
		colunaTemp--;

	}


	colunaTemp = pos.X;
	if (flag_paralelo == true) // caso o paralelo tenha que ser fechado
	{
		aux = 0;// variavel auxiliar

		pos.Y = posy_aux;
		//o (posy - aux)-1 é muito importante pq quando vc reposiciona o paralelo da direita havera conteudo na linha logo é necessario olhar a linha
		// de cima
		while (matriz_desenho[(pos.Y - aux) - 1][pos.X] != 0xc4 && matriz_desenho[(pos.Y - aux) - 1][pos.X] != '6' && matriz_desenho[(pos.Y - aux) - 1][pos.X] != '7')
		{
			if ((pos.Y - aux) < 0){ break; }
			if (matriz_desenho[(pos.Y - aux) - 1][pos.X] != 0xc4 && matriz_desenho[(pos.Y - aux) - 1][pos.X] != 0)
			{
				aux = 0;
				return;
			}
			aux++;
		}
		aux++;
		//VaiParaXY(1, 20); printf("Aux:%d", aux);
		// ajuste necessario pois o while acima esta sempre testando a posição acima, fazendo com que ele acabe uma iteração antes.

		if ((pos.Y - aux) <= 0){ aux = 0; }

		posy_aux = pos.Y - 1;

		if (matriz_desenho[pos.Y - aux][pos.X] == 0xc4)
		{
			VaiParaXY(pos.X, pos.Y - aux); printf_s("%c", 0xc2);
		}
		else if (matriz_desenho[pos.Y - aux][pos.X] == '7')
		{
			VaiParaXY(pos.X, pos.Y - aux); printf_s("%c", 0xb4);
		}
		matriz_desenho[pos.Y - aux][pos.X] = '8'; matriz_protocolo[pos.Y - aux][pos.X] = 0x88;
		VaiParaXY(pos.X, pos.Y); printf_s("%c", 0xd9);
		matriz_desenho[pos.Y][pos.X] = '7'; matriz_protocolo[pos.Y][pos.X] = 0x87;
		while (matriz_desenho[posy_aux][pos.X] != '8')
		{
			VaiParaXY(pos.X, posy_aux);
			printf_s("%c", 0xb3);
			matriz_desenho[posy_aux][pos.X] = 0xb3;
			posy_aux--;
		}
		aux = 1;
		posy_aux = pos.Y;
		//VaiParaXY(10, 10); printf_s("posy_aux:%d\tposx-aux:%d", posy_aux, (posy - aux));
		//
		while (matriz_desenho[posy_aux][pos.X - aux] != 0xc3 && matriz_desenho[posy_aux][pos.X - aux] != '5' && matriz_desenho[posy_aux][pos.X - aux] == 0)
		{


			VaiParaXY(pos.X - aux, posy_aux); printf_s("%c", 0xc4);
			matriz_desenho[posy_aux][pos.X - aux] = 0xc4; matriz_protocolo[posy_aux][pos.X - aux] = 0x84;




			aux++;
		}



		aux = 0;
		flag_paralelo = false;
	}
	pos_apaga.X = -1;
	pos_apaga.Y = -1;
	LimiteMax = 9998;
	LimiteMin = 1;
	colunaTemp = pos.X;

	while (colunaTemp > 0)//***************procura o complemento do paralelo , caso ele  encontre , ele habilita com que outro paralelo possa ser apagado
	{
		if (matriz_desenho[pos.Y][colunaTemp] == '6')
		{
			flag5_8 = false;
			break;
		}


		colunaTemp--;
	}
	if (espaco_paralelo == -1 && flag_paralelo == true)//***********alterado dia 24/06, bug ao apertar o fecha paralelo sem um paralelo aberto, estava setando os limites do espaço do paralelo
	{
		espaco_paralelo = pos.X;
		flag_paralelo = false;
	}//*********************************************************************************************************************
	else if (espaco_paralelo != -1)espaco_paralelo = -1;
	apagar_antiga_marcacao();
	VaiParaXY(pos.X, pos.Y);
	Localizar();
	preencher_nova_marcacao();
}

void teste() // função usada para verficar as variaveis do programa e/ou a linha da matriz 
{

	VaiParaXY(5, (14 + (1 + ((network - 1) * 18)))); printf("pos.Y:%d espaco_paralelo:%d network:%d ", pos.Y, espaco_paralelo, network);
	//VaiParaXY(0, 23); printf_s("flag1: %d", flag1);
	//VaiParaXY(45, 22); printf_s("flagParalelo : %d", flag_paralelo);
	//VaiParaXY(45, 23); printf_s("caractere : %d", matriz_desenho[pos.Y][pos.X]);
	for (int i = 0; i < 80; i++)
	{
		VaiParaXY(i, 15 + (1 + ((network - 1) * 18))); printf_s("%c", matriz_protocolo[pos.Y][i]);
		//if (matriz_desenho[pos.Y][i] >9)i++;
	}



	VaiParaXY(5, (14 + (1 + ((network - 1) * 18)))); printf("                                                  ", (16 + ((network - 1) * 18)), pos.Y, network);
	for (int i = 0; i < 80; i++)
	{
		VaiParaXY(i, 15 + (1 + ((network - 1) * 18))); printf_s(" ");
		//if (matriz_desenho[pos.Y][i] >9)i++;
	}

	apagar_antiga_marcacao();
	VaiParaXY(pos.X, pos.Y);
	Localizar();
	preencher_nova_marcacao();


}

void desenhar(int linha)
{
	for (int i = 0; i < 80; i++)
	{
		
			

	
		switch (matriz_desenho[linha][i])
		{
		case 0xc4:
			if (i == 0)
			{
				VaiParaXY(0, linha); printf_s("%c", 0xc3);

			}
			else
			{
				VaiParaXY(i, linha ); printf_s("%c", 0xc4);
				cout << (linha / 18) + 1;
			
			}
			break;
		case 0xb4:
			VaiParaXY(i, linha ); printf_s("%c", 0xB4);

			break;
		case 0x20:
			VaiParaXY(i, linha ); printf_s("%c", 0x20);
			break;
		case 0xc3:
			VaiParaXY(i, linha ); printf_s("%c", 0xc3);
			break;
		case 0x2f:
			VaiParaXY(i, linha); printf_s("%c", 0x2f);
			break;
		case 12:
			VaiParaXY(i, linha ); printf_s("p");
			break;
		case '6':
			VaiParaXY(i, linha ); printf_s("%c", 0xc0);
			break;
		case '7':
			VaiParaXY(i, linha ); printf_s("%c", 0xd9);
			break;
		case 0xb3:
			VaiParaXY(i, linha ); printf_s("%c", 0xb3);
			break;
		case '5':
			if (matriz_desenho[linha][i - 1] != 0)
			{
				VaiParaXY(i, linha ); printf_s("%c", 0xc2);
			}
			else VaiParaXY(i, linha ); printf_s("%c", 0xc3);
			break;
		case '8':
			if (matriz_desenho[linha][i + 1] != 0)
			{
				VaiParaXY(i, linha ); printf_s("%c", 0xc2);
			}
			else VaiParaXY(i, linha ); printf_s("%c", 0xb4);
			break;
		case 0:
			VaiParaXY(i, linha ); printf(" ");
			cout << (linha / 18) + 1;
		
			break;


		case 11:
			if (i == 0)
			{
				VaiParaXY(i, linha); printf("%c", 0xc3);
			}

			else if (i == 79)
			{
				VaiParaXY(i, linha ); printf("%c", 0xb4);
			}
			break;

		case 0xcd:
			VaiParaXY(i, linha ); printf("%c", 0xcd);
			break;

		case 0x28:
			VaiParaXY(i, linha ); printf("%c", 0x28);
			break;

		case 0x29:
			VaiParaXY(i, linha ); printf("%c", 0x29);
			break;
		default:
			if (i == 9)
			{
			
				VaiParaXY(i, linha ); printf("%d",matriz_desenho[linha][i]);
			
			}
			else
			{
				VaiParaXY(i, linha ); printf("%c",matriz_desenho[linha][i]);
			}
			break;
		}
		
	}
	VaiParaXY(pos.X, pos.Y);
}
void empurra_vertical(void)
{
	int extremaDireita = 0, extremaEsquerda = 0, ultimaLinha = 0;
	int coluna_temp = pos.X, linha_temp = pos.Y;

	while (linha_temp != (16 + ((network - 1) * 18)))
	{
		if (matriz_desenho[linha_temp][coluna_temp] != 0)
		{

			ultimaLinha = linha_temp;
		}
		linha_temp++;


	}

	for (int i = 1; i < 4; i++)
	{
		if (matriz_desenho[ultimaLinha + i][pos.X] != 0)
		{

			return;
		}
	}

	linha_temp = ultimaLinha;

	while (linha_temp != pos.Y && linha_temp != (1 + ((network - 1) * 18)))
	{
		//PROCURA UM 7 À DIREITA

		while (matriz_desenho[linha_temp][coluna_temp] != '7' && matriz_desenho[linha_temp][coluna_temp] != '5')
		{

			coluna_temp++;

		}
		if (matriz_desenho[linha_temp][coluna_temp] == '7')
		{
			while (matriz_desenho[linha_temp][coluna_temp] != '8')
			{
				linha_temp--;
				if (matriz_desenho[linha_temp][coluna_temp + 1] != 0xc4 && matriz_desenho[linha_temp][coluna_temp] == '8' && matriz_desenho[linha_temp][coluna_temp + 1] != '7')linha_temp--;

			}
		}

		else if (matriz_desenho[linha_temp][coluna_temp] == '5')
		{
			while (matriz_desenho[linha_temp][coluna_temp] != '6')
			{
				linha_temp++;
			}

		}


	}

	extremaDireita = coluna_temp;

	linha_temp = ultimaLinha;
	coluna_temp = pos.X;

	while (linha_temp != pos.Y && linha_temp != (1 + ((network - 1) * 18)))
	{
		//PROCURA UM 6 À ESQUERDA
		//teste();
		while (matriz_desenho[linha_temp][coluna_temp] != '6' && matriz_desenho[linha_temp][coluna_temp] != '8')
		{
			coluna_temp--;
			/*VaiParaXY(coluna_temp, linha_temp);
			_getch();*/
		}

		if (matriz_desenho[linha_temp][coluna_temp] == '6')
		{
			while (matriz_desenho[linha_temp][coluna_temp] != '5')
			{
				linha_temp--;
				if (matriz_desenho[linha_temp][coluna_temp - 1] != 0xc4 && matriz_desenho[linha_temp][coluna_temp] == '5' && matriz_desenho[linha_temp][coluna_temp - 1] != '6')linha_temp--;

			}
		}

		else if (matriz_desenho[linha_temp][coluna_temp] == '8')
		{
			while (matriz_desenho[linha_temp][coluna_temp] != '7')
			{
				linha_temp++;
			}

		}


	}
	extremaEsquerda = coluna_temp;
	int aux_ultimaLinha = ultimaLinha;
	while (ultimaLinha != pos.Y && ultimaLinha != (1 + ((network - 1) * 18)))
	{

		for (int i = extremaEsquerda; i <= extremaDireita; i++)
		{

			matriz_desenho[ultimaLinha + 3][i] = matriz_desenho[ultimaLinha][i];
			matriz_buffer[ultimaLinha + 3][i] = matriz_buffer[ultimaLinha][i];
			matriz_protocolo[ultimaLinha + 3][i] = matriz_protocolo[ultimaLinha][i];







			matriz_desenho[ultimaLinha][i] = 0;
			matriz_buffer[ultimaLinha][i] = " ";
			matriz_protocolo[ultimaLinha][i] = 0xff;
			VaiParaXY(i, ultimaLinha); printf_s(" ");
			desenhar(ultimaLinha + 3);







		}


		ultimaLinha--;

	}
	while (aux_ultimaLinha != pos.Y && aux_ultimaLinha != (1 + ((network - 1) * 18)))
	{
		for (int i = extremaEsquerda; i <= extremaDireita; i++)
		{
			if (matriz_buffer[aux_ultimaLinha + 3][i] != "x")
			{
				VaiParaXY(i, aux_ultimaLinha + 2); cout << matriz_buffer[aux_ultimaLinha + 3][i];
			}

		}
		aux_ultimaLinha--;
	}


	linha_temp = pos.Y;
	for (int i = extremaEsquerda; i <= extremaDireita; i++)
	{
		if (matriz_desenho[linha_temp][i] == '5' || matriz_desenho[linha_temp][i] == '8' || matriz_desenho[linha_temp][i] == 0xb3)
		{
			linha_temp++;
			while (matriz_desenho[linha_temp][i] != 0xb3 && matriz_desenho[linha_temp][i] != '6' && matriz_desenho[linha_temp][i] != '7')
			{
				matriz_desenho[linha_temp][i] = 0xb3;
				VaiParaXY(i, linha_temp); printf_s("%c", 0xb3);
				linha_temp++;

			}
			linha_temp = pos.Y;
		}
	}

}
void apaga_network(int net)
{
	int inicio = ((net - 1) * 18);
	int final = (17 + ((numeroNovaLinha)* 18));
	while (inicio <= final)
	{
		for (int coluna = 0; coluna < 80; coluna++)
		{
			VaiParaXY(coluna, inicio); printf(" ");
			matriz_desenho[inicio][coluna] = matriz_desenho[inicio + 18][coluna];
		}
		desenhar(inicio);
		inicio++;
	}
	numeroNovaLinha--;
	inicio = ((net - 1) * 18);
	while (net <= numeroNovaLinha)
	{
		//VaiParaXY(0, inicio); printf("Network: %d", net);
		net++;
		inicio = ((net - 1) * 18);
	}

}
void saida(void)
{
	Localizar();

	if (matriz_desenho[pos.Y][pos.X - 1] == 0xc3)pos.X++;//  não deixa colocar um contato grudado no outro

	int linhaPos = pos.Y;
	///*******************************************************************Segurança

	if (linhaPos > (16 + ((network - 1) * 18))) return;
	if (linhaPos > ((numeroNovaLinha * 18)))return;

	for (int q = 1; q < 3; q++)
	{
		if (matriz_desenho[linhaPos + q][76] == 0x28)return;

	}

	for (int q = 1; q < 3; q++)
	{
		if (matriz_desenho[linhaPos - q][76] == 0x28)
		{
			pos.Y += (3 - q);
			break;
		}

	}

	VaiParaXY(pos.X, linhaPos);


	hWnd = CreateWindowEx(NULL, "Window Class", "Endereço da variavel", WS_OVERLAPPEDWINDOW, 100, 100, 200, 120, NULL, NULL, hInst, NULL);

	if (!hWnd)
	{
		int nResult = GetLastError();
		MessageBox(NULL, "Window creation failed\r\n", "Window Creation Failed", MB_ICONERROR);
	}
	ShowWindow(hWnd, 4);
	MSG msg;
	ZeroMemory(&msg, sizeof(MSG));

	while (GetMessage(&msg, NULL, 0, 0))
	{
		TranslateMessage(&msg);
		DispatchMessage(&msg);
	}

	matriz_protocolo[pos.Y][76] = verifica_buffer(0x10);
	matriz_buffer[pos.Y][76] = buffer;


	if (flag_mem)
	{
		matriz_protocolo[pos.Y][77] = aux_buffer;
		flag_mem = false;

	}

	if (buffer[0] == NULL || flag_sintaxe == true)
	{

		MessageBox(NULL, buffer, "Erro", MB_ICONERROR);
		flag_sintaxe = false;
		return;
	}


	linhaPos = pos.Y;

	VaiParaXY(74, linhaPos - 1); printf_s("%s", buffer);


	if (matriz_desenho[pos.Y][74] == 0xC4)
	{
		VaiParaXY(76, linhaPos); printf_s("%c", 0x28); //Simbolo (
		matriz_desenho[linhaPos][76] = 0x28;

		VaiParaXY(77, linhaPos); printf_s("%c", 32);// espaço
		matriz_desenho[linhaPos][77] = 32;

		VaiParaXY(78, pos.Y); printf_s("%c", 0x29);//Simbolo )
		matriz_desenho[linhaPos][78] = 0x29;

		/*VaiParaXY(79, linhaPos); printf_s("%c", 0xB4);
		matriz_desenho[linhaPos][79] = 11;*/

		VaiParaXY(76, linhaPos);
	}
	else if (linhaPos >  (1 + ((network - 1) * 18)))
	{


		while (matriz_desenho[linhaPos][75] == 0)
		{
			matriz_desenho[linhaPos][75] = 0xb3;
			VaiParaXY(75, linhaPos); printf("%c", 0xb3);
			linhaPos--;

		}
		if (linhaPos == (1 + ((network - 1) * 18)))
		{
			matriz_desenho[linhaPos][75] = '5'; matriz_protocolo[linhaPos][75] = 0x85;
			VaiParaXY(75, linhaPos); printf("%c", 0xc2);
		}
		else
		{
			matriz_desenho[linhaPos][75] = '5'; matriz_protocolo[linhaPos][75] = 0x85;
			VaiParaXY(75, linhaPos); printf("%c", 0xc3);
		}

		linhaPos = pos.Y;
		if (matriz_desenho[linhaPos][75] == 0xb3)
		{
			VaiParaXY(75, linhaPos); printf("%c", 0xc0);
			matriz_desenho[linhaPos][75] = '6'; matriz_protocolo[linhaPos][75] = 0x86;
		}
		else
		{
			VaiParaXY(75, linhaPos); printf("%c", 0xc3);
			matriz_desenho[linhaPos][75] = '6'; matriz_protocolo[linhaPos][75] = 0x86;
		}

		VaiParaXY(76, linhaPos); printf_s("%c", 0x28); //Simbolo (
		matriz_desenho[linhaPos][76] = 0x28;

		VaiParaXY(77, linhaPos); printf_s("%c", 32);// espaço
		matriz_desenho[linhaPos][77] = 32;

		VaiParaXY(78, pos.Y); printf_s("%c", 0x29);//Simbolo )
		matriz_desenho[linhaPos][78] = 0x29;

		VaiParaXY(79, linhaPos); printf_s("%c", 0xB4);
		matriz_desenho[linhaPos][79] = 11;

		//VaiParaXY(74, linhaPos - 1); printf_s("%d", matriz_protocolo[pos.Y][76]);
		//VaiParaXY(78, linhaPos - 1); printf_s("%d", matriz_protocolo[pos.Y][77]);
		if (matriz_buffer[pos.Y][76] != "x")
		{
			VaiParaXY(74, linhaPos - 1); cout << matriz_buffer[pos.Y][76];
		}

			


	}
	apagar_antiga_marcacao();
	Localizar();
	preencher_nova_marcacao();
}
#pragma endregion Funções do DesenhaLadder
void compilar(int networksCompila)
{

	EXP = "";


	while (net != networksCompila)
	{
		int x = 0;
		for (int i = (1 + (net * 18)); i <= (16 + (net * 18)); i++, x++)
		{
			for (int j = 1; j <= 79; j++)
			{

				matriz[x][j] = matriz_protocolo[i][j];

				if (matriz_desenho[i][j] == 0xc4)LinhaEncontrada = true;
				if (matriz_desenho[i][j] == 0x28 && flagContato == true)flagLinhaVazia = false;
				if (matriz_desenho[i][j] == 0xb4 && LinhaEncontrada == true)flagContato = true;

				if (matriz_desenho[i][j] == 0)
				{
					LinhaEncontrada = false;
					flagContato = false;
					flagLinhaVazia = true;
				}
				if (matriz_desenho[i][j] == '7' && matriz_desenho[i][j + 1] == 0 || matriz_desenho[i][j] == '8' && matriz_desenho[i][j + 1] == 0)
				{
					if (flagLinhaVazia && LinhaEncontrada == true)
					{
						//VaiParaXY(15, (net * 18)); printf_s("ERRO,LINHA VAZIA ENCONTRADA!!!"); _getch();
						//VaiParaXY(15, (net * 18)); printf_s("                                ");
						//	MessageBox(NULL, "Linha vazia encontrada!\r\n", "Erro de compilação", MB_ICONERROR);
						//net = 0;
						//VaiParaXY(1, 1); network = 1;
						//return;
					}
				}
			}



			if (flagLinhaVazia && LinhaEncontrada == true)
			{
				//VaiParaXY(15, (net * 18)); printf_s("ERRO,LINHA VAZIA ENCONTRADA!!!"); _getch();
				//VaiParaXY(15, (net * 18)); printf_s("                                ");
				//MessageBox(NULL, "Linha vazia encontrada!\r\n", "Erro de compilação", MB_ICONERROR);
				//net = 0;
				//VaiParaXY(1, 1); network = 1;
				//return;
			}
			flagLinhaVazia = true;
			LinhaEncontrada = false;
			flagContato = false;


		}




		funcao_principal();
		linhaCompila = 0;
		colunaCompila = 0;
		colunaVolta_aux = 0;
		indiceParalelos = 0;

		flagDois = false;
		flagParaleloCompila = false;
		flag_volta = false;

		net++;
	}
	net = 0;
	VaiParaXY(1, 1); network = 1;


	EXP += "143;";
	VaiParaXY(5, 60);
	if (EXP.size() < 50)
	{
		grava_matriz(EXP);
		MessageBox(NULL, "Compilado", "Aviso", MB_ICONINFORMATION);
	}
	else
	{
		MessageBox(NULL, "Programa muito longo", "Erro", MB_ICONERROR);
		std::ofstream writer(cmdtxt);
		writer << "ERRO";

	}

	return;

}

//**********************************************FUNÇOES DO COMPILADOR
#pragma region Compilador
void funcao_paralelo()
{
	VaiParaXY(10, 20);


	int colFinal = 0;
	int line = 0, columm = 0;

	flagParaleloCompila = true;
	columm = colunaCompila;
	line = linhaCompila;
	//colunaVolta[indiceParalelos] = colunaCompila;
	//linhaVolta[indiceParalelos] = linhaCompila;

	//indiceParalelos++;
	linhaCompila++;
	//printf_s("%d", linhaCompila);

	do
	{
		while (matriz[linhaCompila][colunaCompila] != 135)
		{
			//VaiParaXY(colunaCompila, linhaCompila); _getch();
			if ((matriz[linhaCompila - 1][colunaCompila] == 133 && linhaCompila == 1) || (matriz[linhaCompila][colunaCompila] == 133 && linhaCompila != 1))
			{
				while (matriz[linhaCompila][colunaCompila] != 134)
				{
					linhaCompila++;
					//VaiParaXY(colunaCompila, linhaCompila); _getch();
				}
			}
			while (matriz[linhaCompila][colunaCompila] != 133 && matriz[linhaCompila][colunaCompila] != 135)
			{
				colunaCompila++;
				//VaiParaXY(colunaCompila, linhaCompila); _getch();
			}
		}

		while (matriz[linhaCompila][colunaCompila] != 136 || matriz[linhaCompila][colunaCompila + 1] == 255)
		{
			linhaCompila--;
			//VaiParaXY(colunaCompila, linhaCompila); _getch();
		}

	} while (linhaCompila != 0);

	colFinal = colunaCompila;
	colunaCompila++;
	//VaiParaXY(colFinal, linhaCompila); _getch(); _getch();

	colunaCompila = columm;
	linhaCompila = line;


	//EXP += "133;";
	//EXP += "135;";


	while (colunaCompila <= colFinal && flagParaleloCompila == true)
	{



		if ((matriz[linhaCompila][colunaCompila] & 64) == 64 && matriz[linhaCompila][colunaCompila] != 255)//inicio contato aberto
		{
			//printf_s("q");
			stringstream conv;
			conv << matriz[linhaCompila][colunaCompila];
			//cout << matriz[linhaCompila + 1][colunaCompila - 2]; _getch();
			EXP += conv.str();
			EXP += ";";


			if (matriz[linhaCompila][colunaCompila + 1] != 132)
			{
				stringstream conv2;
				conv2 << matriz[linhaCompila][colunaCompila + 1];
				//cout << matriz[linhaCompila][colunaCompila + 1]; _getch();
				EXP += conv2.str();
				EXP += ";";
			}

		}

		if (colunaCompila == colFinal)
		{
			//EXP += "135;";
			//VaiParaXY(colunaCompila, linhaCompila); _getch();

			/*/if (flag5 == true && colunaVolta[indiceParalelos - 1] == columm)
			{
			flag5 = false;
			EXP += "];";
			}*/
			if (flagParaleloCompila && indiceParalelos != 0)
			{

				//EXP += "135;";//(

				//VaiParaXY(5, 24); printf("%d,%d", linhaVolta[indiceParalelos-1], colunaVolta[indiceParalelos-1]);
				colunaCompila = colunaVolta[indiceParalelos - 1];
				colunaVolta[indiceParalelos - 1] = NULL;
				linhaCompila = linhaVolta[indiceParalelos - 1];
				linhaVolta[indiceParalelos - 1] = NULL;

				linhaCompila++;

				indiceParalelos--;
				//VaiParaXY(colunaCompila, linhaCompila); _getch();
				/*if (flagvolta)
				{
				flagvolta = false;
				colunaCompila++; continue;
				}*/
				if (colunaCompila != columm)
				{
					EXP += "131;";
				}
				EXP += "136;";//+
				//VaiParaXY(colunaCompila, linhaCompila); _getch();

				if (indiceParalelos == -1)
				{
					flagParaleloCompila = false;
					indiceParalelos = 0;
				}


				while (matriz[linhaCompila][colunaCompila] != 134)
				{

					if (matriz[linhaCompila + 1][colunaCompila] == 133)
					{
						colunaVolta[indiceParalelos] = colunaCompila;
						linhaVolta[indiceParalelos] = linhaCompila + 1;
						indiceParalelos++;
						linhaCompila++;
						colunaCompila++;
						break;
						//VaiParaXY(5, 35); printf("linhaC: %d ,colunaC: %d , matriz: %d, linha+1: %d ", linhaCompila, colunaCompila, matriz[linhaCompila + 1][colunaCompila], linhaCompila + 1); _getch();
						//VaiParaXY(colunaCompila, linhaCompila + 1); printf("%c",0xdb); _getch();
						//VaiParaXY(5, 35); printf("matriz : %d", matriz[linhaCompila + 1][colunaCompila]);

						//flagvolta = true;
						//continue;

					}

					linhaCompila++;



				}


			}
		}

		if (matriz[linhaCompila][colunaCompila] == 135)
		{
			while (matriz[linhaCompila][colunaCompila] != 136 && matriz[linhaCompila][colunaCompila + 1] != 0xc4)linhaCompila--;

		}
		//VaiParaXY(colunaCompila, linhaCompila); _getch();
		if (matriz[linhaCompila][colunaCompila] == 133 /*&& linhaCompila>1*/)
		{


			colunaVolta[indiceParalelos] = colunaCompila;
			linhaVolta[indiceParalelos] = linhaCompila;
			indiceParalelos++;
			if (colunaCompila != columm)
			{
				flag5 = true;
				EXP += "135;";
			}
			else EXP += "133;";
			columm = colunaCompila;
		}

		colunaCompila++;
		//VaiParaXY(colunaCompila, linhaCompila); _getch();
		//VaiParaXY(colunaCompila, linhaCompila); _getch();
	}



	//linhaCompila++;
	EXP += "134;";//)
	flag5 = false;
	return;


}
void funcao_principal()
{
	linhaCompila = 0;
	while (linhaCompila < 16)
	{
		if ((matriz[linhaCompila][76] & 64) == 0 && (matriz[linhaCompila][76]) != 132)
		{
			stringstream conv;
			conv << matriz[linhaCompila][76];

			//cout << matriz[linhaCompila][76]; _getch();
			EXP += conv.str();
			EXP += ";";
			if (matriz[linhaCompila][77] != 132)
			{
				stringstream conv2;
				conv2 << matriz[linhaCompila][77];
				//cout << matriz[linhaCompila][77]; _getch();
				EXP += conv2.str();
				EXP += ";";

			}

		}

		linhaCompila++;
	}
	//EXP += "=;";
	linhaCompila = 0;


	while (colunaCompila < 80)
	{
		//VaiParaXY(colunaCompila, linhaCompila); _getch();
		if ((matriz[linhaCompila][colunaCompila] & 64) == 64 && matriz[linhaCompila][colunaCompila] != 255)//inicio de contato 
		{
			//VaiParaXY(30, 29); printf_s("%d, %d", linhaCompila, colunaCompila); _getch();
			stringstream conv;
			conv << matriz[linhaCompila][colunaCompila];

			cout << matriz[linhaCompila][colunaCompila]; //_getch();
			EXP += conv.str();
			EXP += ";";
			if (matriz[linhaCompila][colunaCompila + 1] != 132)
			{
				//VaiParaXY(30, 30); printf_s("%d, %d, entrouu", linhaCompila, colunaCompila + 1); _getch();
				//conv << matriz_protocolo[linhaCompila+1][colunaCompila];
				stringstream conv2;
				conv2 << matriz[linhaCompila][colunaCompila + 1];
				cout << matriz[linhaCompila][colunaCompila + 1];// _getch();
				EXP += conv2.str();
				EXP += ";";

			}

		}


		if (matriz[linhaCompila][colunaCompila] == 133 && colunaCompila<75)//inicio de paralelo
		{

			funcao_paralelo();
		}


		colunaCompila++;



	}
	EXP += "130;"; //x

}
//***************************************************VOLTA PARA O ULTIMO PARALELO

#pragma endregion Funções do compilador
string escreve_path(string startup_path, string file_name)
{

	size_t pos;
	string str;
	pos = startup_path.find("\CompilaLadder4.exe");
	str = startup_path.substr(0, pos);
	str += file_name;

	return str;

}
void mouse()
{

	HANDLE hIn;
	DWORD EventCount;
	INPUT_RECORD InRec;
	DWORD NumRead;

	hIn = GetStdHandle(STD_INPUT_HANDLE);

	GetNumberOfConsoleInputEvents(hIn, &EventCount);
	if (EventCount)
	{

		ReadConsoleInput(hIn, &InRec, 1, &NumRead);

		if (InRec.EventType == MOUSE_EVENT)
		{

			if (InRec.Event.MouseEvent.dwEventFlags == STN_CLICKED)
			{
				apagar_antiga_marcacao();
				pos.X = InRec.Event.MouseEvent.dwMousePosition.X;
				pos.Y = InRec.Event.MouseEvent.dwMousePosition.Y;
				preencher_nova_marcacao();
				if (pos.Y > LimiteMin)	
				if (matriz_desenho[pos.Y - 1][pos.X] == 0xcd)
				{
					network--;
			
				}
				if (pos.Y <= LimiteMax)
				{
					if (matriz_desenho[pos.Y + 1][pos.X] == 0xcd)
					{
						network++;
						
					}
				}

			}
			if (InRec.Event.MouseEvent.dwEventFlags == DOUBLE_CLICK)
			{



				if (matriz_desenho[pos.Y][pos.X] == 0xb4 || matriz_desenho[pos.Y][pos.X] == 0x28)
				{


					hWnd = CreateWindowEx(NULL, "Window Class", "Endereço da variavel", WS_OVERLAPPEDWINDOW, 100, 100, 200, 120, NULL, NULL, hInst, NULL);

					if (!hWnd)
					{
						int nResult = GetLastError();
						MessageBox(NULL, "Window creation failed\r\n", "Window Creation Failed", MB_ICONERROR);
					}
					ShowWindow(hWnd, 4);
					MSG msg;
					ZeroMemory(&msg, sizeof(MSG));

					while (GetMessage(&msg, NULL, 0, 0))
					{
						TranslateMessage(&msg);
						DispatchMessage(&msg);
					}

				}
			}
		}
	}
}
void apagar_antiga_marcacao()
{
	if (matriz_desenho[aux_mouse.Y][aux_mouse.X] != 0 && pos.X > 0)
	{
		if (matriz_desenho[aux_mouse.Y][aux_mouse.X] < '9')
		{
			switch (matriz_desenho[aux_mouse.Y][aux_mouse.X])
			{
			case '5':
				if (matriz_desenho[aux_mouse.Y][aux_mouse.X - 1] == 0)
				{
					VaiParaXY(aux_mouse.X, aux_mouse.Y); Cor(0xf0); printf_s("%c", 0xc3);
					VaiParaXY(aux_mouse.X, aux_mouse.Y);
				}

				else
				{
					VaiParaXY(aux_mouse.X, aux_mouse.Y); Cor(0xf0);; printf_s("%c", 0xc2);
					VaiParaXY(aux_mouse.X, aux_mouse.Y);
				}
				break;
			case '6':
				VaiParaXY(aux_mouse.X, aux_mouse.Y); Cor(0xf0); printf_s("%c", 0xc0);
				VaiParaXY(aux_mouse.X, aux_mouse.Y);
				break;
			case '7':
				VaiParaXY(aux_mouse.X, aux_mouse.Y); Cor(0xf0); printf_s("%c", 0xd9);
				VaiParaXY(aux_mouse.X, aux_mouse.Y);
				break;
			case '8':
				if (matriz_desenho[aux_mouse.Y][aux_mouse.X + 1] == 0)
				{
					VaiParaXY(aux_mouse.X, aux_mouse.Y); Cor(0xf0); printf_s("%c", 0xb4);
					VaiParaXY(aux_mouse.X, aux_mouse.Y);
				}
				else
				{
					VaiParaXY(aux_mouse.X, aux_mouse.Y); Cor(0xf0); printf_s("%c", 0xc2);
					VaiParaXY(aux_mouse.X, aux_mouse.Y);

				}

				break;
			default:
				break;
			}

		}
		else
		{
			VaiParaXY(aux_mouse.X, aux_mouse.Y); Cor(0xf0);; printf_s("%c", matriz_desenho[aux_mouse.Y][aux_mouse.X]);
			VaiParaXY(aux_mouse.X, aux_mouse.Y);
		}
	}

}
void preencher_nova_marcacao()
{
	aux_mouse.X = pos.X;
	aux_mouse.Y = pos.Y;
	if (matriz_desenho[pos.Y][pos.X] != 0 && pos.X > 0)
	{
		if (matriz_desenho[aux_mouse.Y][aux_mouse.X] < '9')
		{
			switch (matriz_desenho[aux_mouse.Y][aux_mouse.X])
			{
			case '5':
				if (matriz_desenho[aux_mouse.Y][aux_mouse.X - 1] == 0)
				{
					VaiParaXY(aux_mouse.X, aux_mouse.Y); Cor(0xA0);; printf_s("%c", 0xc3);
					VaiParaXY(aux_mouse.X, aux_mouse.Y);
				}
				else
				{
					VaiParaXY(aux_mouse.X, aux_mouse.Y); Cor(0xA0);; printf_s("%c", 0xc2);
					VaiParaXY(aux_mouse.X, aux_mouse.Y);
				}
				break;
			case '6':
				VaiParaXY(aux_mouse.X, aux_mouse.Y); Cor(0xA0);; printf_s("%c", 0xc0);
				VaiParaXY(aux_mouse.X, aux_mouse.Y);
				break;
			case '7':
				VaiParaXY(aux_mouse.X, aux_mouse.Y); Cor(0xA0);; printf_s("%c", 0xd9);
				VaiParaXY(aux_mouse.X, aux_mouse.Y);
				break;
			case '8':
				if (matriz_desenho[aux_mouse.Y][aux_mouse.X + 1] == 0)
				{
					VaiParaXY(aux_mouse.X, aux_mouse.Y); Cor(0xA0); printf_s("%c", 0xb4);
					VaiParaXY(aux_mouse.X, aux_mouse.Y);
				}
				else
				{
					VaiParaXY(aux_mouse.X, aux_mouse.Y); Cor(0xA0); printf_s("%c", 0xc2);
					VaiParaXY(aux_mouse.X, aux_mouse.Y);

				}
				break;
			default:
				break;
			}

		}
		else
		{
			VaiParaXY(aux_mouse.X, aux_mouse.Y); Cor(0xA0);; printf_s("%c", matriz_desenho[aux_mouse.Y][aux_mouse.X]);
			VaiParaXY(aux_mouse.X, aux_mouse.Y);
			//if (aux_mouse )

		}

	}
	Cor(0xf0);



}
LRESULT CALLBACK WinProc(HWND hWnd, UINT msg, WPARAM wParam, LPARAM lParam)
{
	switch (msg)

	{
	case WM_CREATE:
	{
					  // Create an edit box
					  hEdit = CreateWindowEx(WS_EX_CLIENTEDGE, "EDIT", "", WS_CHILD | WS_VISIBLE | ES_AUTOVSCROLL | ES_AUTOHSCROLL, 10, 20, 100, 20, hWnd, (HMENU)IDC_MAIN_EDIT, GetModuleHandle(NULL), NULL);
					  HGDIOBJ hfDefault = GetStockObject(DEFAULT_GUI_FONT);
					  SendMessage(hEdit, WM_SETFONT, (WPARAM)hfDefault, MAKELPARAM(FALSE, 0));
					  SendMessage(hEdit, WM_SETTEXT, NULL, (LPARAM)"");

					  // Create a push button
					  HWND hWndButton = CreateWindowEx(NULL, "BUTTON", "OK", WS_TABSTOP | WS_VISIBLE | WS_CHILD | BS_DEFPUSHBUTTON, 10, 50, 100, 24, hWnd, (HMENU)IDC_MAIN_BUTTON, GetModuleHandle(NULL), NULL);
					  SendMessage(hWndButton, WM_SETFONT, (WPARAM)hfDefault, MAKELPARAM(FALSE, 0));
	}
		break;

	case WM_COMMAND:
		switch (LOWORD(wParam))
		{
		case IDC_MAIN_BUTTON:
		{




								SendMessage(hEdit, WM_GETTEXT, sizeof(buffer) / sizeof(buffer[0]), reinterpret_cast<LPARAM>(buffer));

								DestroyWindow(hWnd);

		}
			break;
		}
		break;

	case WM_DESTROY:
	{
					   PostQuitMessage(0);
					   return 0;
	}
		break;
	}

	return DefWindowProc(hWnd, msg, wParam, lParam);
}
int verifica_buffer(char tipo)
{
	int buffer_return = 0;
	int ponto = localiza_ponto();

	buffer_return = tipo | buffer_return; // configurar tipo, se saida ou entrada, e se fechado ou aberto, de acordo com o protocolo
	if (verifica_ponto() && verifica_bit(ponto))
	{

		char aux;
		if ((buffer[0] == 'I' && tipo != 0x16) || (buffer[0] == 'Q' && (tipo != 0x40 && tipo != 0x50)))
		{
			buffer_return = buffer_return | 0x20;

			switch (buffer[1])
			{
			case '0':
				aux = buffer[3] - 48;//converte para int, verifique a tabela ascII

				buffer_return = buffer_return | aux;
				break;
			case '1':
				buffer_return = buffer_return | 0x08;

				aux = buffer[3] - 48;//converte para int, verifique a tabela ascII

				buffer_return = buffer_return | aux;
				break;

			default:
				flag_sintaxe = true;
				return 0;
				break;
			}
		}
		else if (buffer[0] == 'M')
		{
			int x = localiza_ponto();

			flag_mem = true;
			buffer_return = buffer_return | (buffer[x + 1] - 48);// converter para int

			if (x == 2)
			{
				aux_buffer = buffer[1] - 48; // converte pra int
				if ((buffer[3] - 48) > 7)
				{
					flag_sintaxe = true;
					return 0;
				}

				grava_buffer(pos.X, pos.Y, buffer);
				return buffer_return;


			}
			else
			{
				flag_sintaxe = true;
				return 0;


			}
			

		}
		else
		{
			flag_sintaxe = true;
			return 0;


		}




	}
	else
	{
		flag_sintaxe = true;
		return 0;
	}
	grava_buffer(pos.X, pos.Y, buffer);
	return buffer_return;
}
bool verifica_ponto()
{


	if (buffer[0] == 'M' && (buffer[2] == '.' || buffer[3] == '.' || buffer[4] == '.')) return true;
	else if (buffer[0] == 'I' && buffer[2] == '.') return true;
	else if (buffer[0] == 'Q' && buffer[2] == '.')return true;
	else
	{
		return false;

	}

}
int localiza_ponto()
{
	int x = 0;

	while (buffer[x] != '.')
	{
		x++;
	}

	return x;
}
bool verifica_bit(int ponto)
{
	if ((buffer[ponto + 1] >= 48 && buffer[ponto + 1] <= 55) && buffer[ponto + 2] == NULL)return true;
	else
	{
		return false;
	}

}
void zera_buffer()
{
	for (int x = 0; x < 20; x++)
	{
		buffer[x] = NULL;

	}


}
bool segure_contato()
{

	for (int a = 0; a <= 6; a++)
	{
		if (matriz_desenho[pos.Y][pos.X + a] != 196)return false;//linha

	}
	for (int b = 0; b <= 3; b++)
	{
		if (matriz_desenho[pos.Y][pos.X - b] != 196)return false;
	}
	return true;

}
void grava_buffer(int x, int y, char* text)
{

	for (char i = 1; i < 7; i++)
	{
		//matriz_protocolo [y][x] = text[i];
		//MessageBox(NULL, matriz_protocolo[y][x], "Window Creation Failed", MB_ICONERROR);

	}


}
void grava_matriz(string texto)
{
	std::ofstream writer(serialtxt);
	writer << texto;

}
void alocacao()
{
	matriz_otmizada = (char**)calloc(numeroNovaLinha, sizeof(char));
	for (int i = 0; i < numeroNovaLinha; i++)
	{
		matriz_otmizada[i] = (char*)calloc(80, sizeof(char));
	}
	if (matriz_otmizada != NULL)
	{
		for (int linha = 0; linha < numeroNovaLinha; linha++)
		{
			for (int coluna = 0; coluna < 80; coluna++)
			{
				matriz_otmizada[linha][coluna] = matriz_protocolo[linha][coluna];

			}

		}

	}
	else
	{
		MessageBox(NULL, "Window creation failed\r\n", "Window Creation Failed", MB_ICONERROR);
	}

}
void desenha_buffer(int linha)
{
	for (char coluna = 0; coluna < 80; coluna++)
	{
		if (matriz_buffer[linha][coluna] == "x")
		{
			
		
		}
		else
		{
			VaiParaXY(coluna, linha - 1);
			cout << matriz_buffer[linha][coluna];
			_getch();
		}
	}
}
bool save()
{
	ofstream writer_desenho(desenhotxt);
	stringstream conv_linha;
	string final_desenho;

	conv_linha << numeroNovaLinha * 18;
	final_desenho += conv_linha.str() + ";";
	MessageBox(NULL, "SALVO COM SUCESSO\r\n", "SALVO", MB_ICONEXCLAMATION);
	for (int linha = 0; linha <=  (numeroNovaLinha * 18); linha++)
	{
		for (int coluna = 0; coluna < 80; coluna++)
		{
			stringstream conv_desenho;
			conv_desenho << matriz_desenho[linha][coluna];
			final_desenho += conv_desenho.str() + ";";


		}

	}

	for (int linha = 0; linha <=  (numeroNovaLinha * 18); linha++)
	{
		for (int coluna = 0; coluna < 80; coluna++)
		{
			stringstream conv_protocolo;
			conv_protocolo << matriz_protocolo[linha][coluna];
			final_desenho += conv_protocolo.str() + ";";


		}

	}
	for (int linha = 0; linha <=  (numeroNovaLinha * 18); linha++)
	{
		for (int coluna = 0; coluna < 80; coluna++)
		{
			stringstream conv_buffer;
			conv_buffer << matriz_buffer[linha][coluna];
			final_desenho += matriz_buffer[linha][coluna] + ";";
		}

	}
	writer_desenho << final_desenho;
	writer_desenho.close();
	return true;



}
void load()
{
	string file;
	ifstream reader(desenhotxt);
	reader >> file;
	reader.close();

	string aux_numLinha;
	int numLinha = 0;
	int aux_cont = 0;
	string aux_des;
	string aux_protocolo;
	string aux_buffer2;




	while (true)
	{
		if (file[aux_cont] == ';')
		{
			aux_cont++;
			break;
		}
		else
		{
			aux_numLinha += file[aux_cont];
			aux_cont++;

		}
	}
	numLinha = stoi(aux_numLinha);

	
	//separar posição por ponto e virgula

	//******************************* matriz desenho
	for (int linha = 0; linha <= numLinha; linha++)
	{
		for (int coluna = 0; coluna < 80; coluna++)
		{
			while (true)
			{
				if (file[aux_cont] == ';')
				{
					aux_cont++;
		
					break;
				}
				else
				{
					aux_des += file[aux_cont];
					aux_cont++;

				}

			}
			matriz_desenho[linha][coluna] = stoi(aux_des);
			aux_des = "";
		}

	}
	
	


	//matriz protocolo *******************************************************
	for (int linha = 0; linha <= numLinha; linha++)
	{
		for (int coluna = 0; coluna < 80; coluna++)
		{
			while (true)
			{
				if (file[aux_cont] == ';')
				{
					aux_cont++;
					break;
				}
				else
				{
					aux_protocolo += file[aux_cont];
					aux_cont++;

					
				}

			}


			matriz_protocolo[linha][coluna] = stoi(aux_protocolo);
		
			
			aux_protocolo = "";
			
			
		}

	}



	//matriz_buffer *************************************************************************
	for (int linha = 0; linha <= numLinha; linha++)
	{
		for (int coluna = 0; coluna < 80; coluna++)
		{
			while (true)
			{
				if (file[aux_cont] == ';')
				{
					aux_cont++;
					break;
				}
				else
				{
					aux_buffer2 += file[aux_cont];
					aux_cont++;


				}

			}
			matriz_buffer[linha][coluna] = aux_buffer2;
			aux_buffer2 = "";
	
		}

	}

	//*************************************************************************************
	//*********************************************************************************
	//desenhar

	
	for (int linha = 0; linha < numLinha; linha++)
	{
		desenhar(linha);
	}

	for (int linha = 0; linha < numLinha; linha++)
	{
		desenha_buffer(linha);
	}

	numeroNovaLinha = numLinha/18;
	
}