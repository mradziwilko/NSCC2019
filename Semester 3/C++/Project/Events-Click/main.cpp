#include <QApplication>
#include "click.h"

int main(int argc, char *argv[]) {

  QApplication app(argc, argv);

  Click window;

  window.resize(250, 150);
  window.setWindowTitle("Click");
  window.show();

  return app.exec();
}
