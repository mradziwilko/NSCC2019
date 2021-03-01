#include <iostream>

class SubSystemOne
{
public:
	void MethodOne(){ std::cout << "Su bSystem 1" << std::endl; };
};

class SubSystemTwo
{
public:
	void MethodTwo(){ std::cout << "Sub System 2" << std::endl; };
};

class SubSystemThree
{
public:
	void MethodThree(){ std::cout << "Sub System 3" << std::endl; }
};

class Facade
{
public:
    Facade()
    {
	pOne = new SubSystemOne();
	pTwo = new SubSystemTwo();
	pThree = new SubSystemThree();
    }

    void MethodA()
    {
	std::cout << "Facade - MethodA" << std::endl;
	pOne->MethodOne();
	pTwo->MethodTwo();
    }

    void MethodB()
    {
	std::cout << "Facade - MethodB" << std::endl;
	pTwo->MethodTwo();
	pThree->MethodThree();
    }

private:
    SubSystemOne *pOne;
    SubSystemTwo *pTwo;
    SubSystemThree *pThree;
};

int main()
{
    Facade *pFacade = new Facade();

    pFacade->MethodA();
    pFacade->MethodB();

    return 0;
}