#include <windows.h>

//Move cursor para posição xy
void VaiParaXY(INT x,INT y)
{
    // Get handle to console output buffer.
    HANDLE hStdout = GetStdHandle( STD_OUTPUT_HANDLE );
	// Set the cursor position.
    COORD Cord;
    Cord.X = x;
    Cord.Y = y;
    SetConsoleCursorPosition( hStdout, Cord );
}
//Retorna a coordenada X do cursor
INT LePosicaoX()
{
	// Get handle to console output buffer.
    HANDLE hStdout = GetStdHandle( STD_OUTPUT_HANDLE );
	// Get current screen information.
    CONSOLE_SCREEN_BUFFER_INFO ScreenBufferInfo = { 0 };
    GetConsoleScreenBufferInfo( hStdout, &ScreenBufferInfo );
	return ScreenBufferInfo.dwCursorPosition.X;
}
//Retorna a coordenada Y do cursor
INT LePosicaoY()
{
	// Get handle to console output buffer.
    HANDLE hStdout = GetStdHandle( STD_OUTPUT_HANDLE );
	// Get current screen information.
    CONSOLE_SCREEN_BUFFER_INFO ScreenBufferInfo = { 0 };
    GetConsoleScreenBufferInfo( hStdout, &ScreenBufferInfo );
	return ScreenBufferInfo.dwCursorPosition.Y;
}
void DesligaCursor()
{
	CONSOLE_CURSOR_INFO CURSOR;// define o tipo de cursor
	CURSOR.dwSize = 1;//define a propriedade do tamanho do cursor
	CURSOR.bVisible = FALSE;//define a propriedade de visão do cursor
	SetConsoleCursorInfo(GetStdHandle(STD_OUTPUT_HANDLE), &CURSOR);//segundo argumento é ponteiro
}
void LigaCursor()
{
	CONSOLE_CURSOR_INFO CURSOR;// define o tipo de cursor
	CURSOR.dwSize = 10;
	CURSOR.bVisible = TRUE;
	SetConsoleCursorInfo(GetStdHandle(STD_OUTPUT_HANDLE), &CURSOR);//segundo argumento é ponteiro
}

void Cor(int valor)
{
	SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), valor);//define a cor de fundo e da letra
	//Defini a cor do texto e atrás dele, o byte está
	//dividido em 2 nibbles (backcolor e textcolor)
}

