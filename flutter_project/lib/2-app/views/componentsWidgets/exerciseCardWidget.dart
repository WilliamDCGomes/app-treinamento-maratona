import 'package:flutter/material.dart';
import 'package:flutter_project/1-base/models/exercise.dart';
import 'package:flutter_project/2-app/views/stylePages/appColors.dart';
import 'package:responsive_sizer/responsive_sizer.dart';
import 'textWidget.dart';

class ExerciseCardWidget extends StatelessWidget {
  final double? widthButton;
  final FontWeight? fontWeight;
  final Color? textColor;
  final Exercise exerciseItem;
  final Function()? onPressed;

  const ExerciseCardWidget(
      { Key? key,
        this.widthButton,
        this.fontWeight,
        this.textColor,
        required this.exerciseItem,
        this.onPressed,
      }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return GestureDetector(
      onTap: onPressed,
      child: Container(
        height: 20.h,
        width: 80.w,
        decoration: BoxDecoration(
          borderRadius: BorderRadius.circular(2.5.h),
          color: exerciseItem.getColor,
          image: DecorationImage(
            image: AssetImage(
              exerciseItem.getImagebackground,
            ),
            fit: BoxFit.cover,
            opacity: exerciseItem.opacityValue,
          ),
        ),
        child: Stack(
          children: [
            Padding(
              padding: EdgeInsets.all(1.h),
              child: Column(
                crossAxisAlignment: CrossAxisAlignment.stretch,
                children: [
                  Row(
                    mainAxisAlignment: MainAxisAlignment.spaceBetween,
                    children: [
                      SizedBox(
                        width: 66.w,
                        child: TextWidget(
                          exerciseItem.title ?? "",
                          maxLines: 1,
                          textColor: AppColors().whiteColor,
                          fontWeight: FontWeight.bold,
                          fontSize: 20.sp,
                          textAlign: TextAlign.start,
                          textOverflow: TextOverflow.ellipsis,
                        ),
                      ),
                      Icon(
                        Icons.favorite,
                        color: exerciseItem.isFavorited ?
                          AppColors().redCardColor :
                          AppColors().blackColor91Percent,
                        size: 8.w,
                      ),
                    ],
                  ),
                  Padding(
                    padding: EdgeInsets.only(top: 3.5.h),
                    child: TextWidget(
                      "Cód. ${exerciseItem.exerciseCode}",
                      textColor: AppColors().whiteColor,
                      fontWeight: FontWeight.bold,
                      fontSize: 20.sp,
                      textAlign: TextAlign.start,
                      textOverflow: TextOverflow.ellipsis,
                    ),
                  ),
                  Padding(
                    padding: EdgeInsets.only(top: 4.h),
                    child: Row(
                      mainAxisAlignment: MainAxisAlignment.spaceBetween,
                      children: [
                        SizedBox(
                          width: 42.w,
                          child: TextWidget(
                            exerciseItem.authorsComment ?? "",
                            maxLines: 1,
                            textColor: AppColors().whiteColor,
                            fontWeight: FontWeight.bold,
                            fontSize: 18.sp,
                            textAlign: TextAlign.start,
                            textOverflow: TextOverflow.ellipsis,
                          ),
                        ),
                        TextWidget(
                          "Dificuldade: ${exerciseItem.difficultyLevel}",
                          textColor: AppColors().whiteColor,
                          fontWeight: FontWeight.bold,
                          fontSize: 18.sp,
                          textAlign: TextAlign.start,
                          textOverflow: TextOverflow.ellipsis,
                        ),
                      ],
                    ),
                  ),
                ],
              ),
            ),
          ],
        ),
      ),
    );
  }
}