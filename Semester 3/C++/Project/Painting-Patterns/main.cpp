#include <QDesktopWidget>
#include <QApplication>
#include "patterns.h"

int main(int argc, char *argv[]) {

  QApplication app(argc, argv);

  Patterns window;

  window.resize(350, 280);
  window.setWindowTitle("Patterns");
  window.show();

  return app.exec();
}
