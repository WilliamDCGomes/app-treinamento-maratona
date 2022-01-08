import 'package:flutter_project/2-app/helpers/paths.dart';
import 'package:flutter_project/2-app/views/stylePages/appColors.dart';
import 'package:uuid/uuid.dart';

class Exercise {
  //#region Attributes
  late String id;
  int? difficultyLevel;
  String? title;
  String? siteOrigem;
  String? necessaryKnowledge;
  String? description;
  String? authorsComment;
  late bool isFavorited;
  //#endregion

  //#region Constructor
  Exercise() {
    id = Uuid().v4();
    isFavorited = false;
  }
  //#endregion

  //#region Encapsulation
  get getColor {
    switch (difficultyLevel) {
      case 2:
        return AppColors().blueCardColor;
      case 3:
        return AppColors().purpleCardColor;
      case 4:
        return AppColors().orangeCardColor;
      case 5:
        return AppColors().redCardColor;
      default:
        return AppColors().greenCardColor;
    }
  }

  get getImagebackground {
    switch (difficultyLevel) {
      case 1:
        return "${Paths().imagesPath}beginnerLevel.jpg";
      case 2:
        return "${Paths().imagesPath}postBeginnerLevel.jpg";
      case 3:
        return "${Paths().imagesPath}intermediateLevel.jpg";
      case 4:
        return "${Paths().imagesPath}postIntermediateLevel.png";
      case 5:
        return "${Paths().imagesPath}hardLevel.png";
    }
  }

  get getStarColor {
    if (isFavorited)
      return AppColors().redCardColor;
    return AppColors().whiteColor;
  }
  //#endregion
}