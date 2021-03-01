#include <QCoreApplication>
#include <iostream>
int main(int argc, char *argv[])
{

    std::cout << "Qt version: " << qVersion() << std::endl;
    QCoreApplication a(argc, argv);
    return a.exec();
}
