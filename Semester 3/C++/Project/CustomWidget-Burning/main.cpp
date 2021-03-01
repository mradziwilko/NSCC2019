#include <QApplication>
#include "burning.h"

int main(int argc, char *argv[]) {

  QApplication app(argc, argv);
  Burning window;

  window.resize(370, 200);
  window.setWindowTitle("The Burning widget");
  window.show();

  return app.exec();
}
