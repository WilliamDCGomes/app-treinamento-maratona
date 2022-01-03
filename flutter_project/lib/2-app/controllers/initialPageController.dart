import 'package:flutter_project/2-app/views/pages/welcomePage.dart';
import 'package:get/get.dart';

class InitialPageController extends GetxController {
  InitialPageController();

  loadFirstScreen(){
    //Configurar para que possa ir direto a tela de menu iniciar
    Get.to(() => WelcomePage());
  }
}
