// Copyright YangZhikang


#include "ElfSelenaCharacterBase.h"

// Sets default values
AElfSelenaCharacterBase::AElfSelenaCharacterBase()
{
 	// Set this character to call Tick() every frame.  You can turn this off to improve performance if you don't need it.
	PrimaryActorTick.bCanEverTick = true;

}

// Called when the game starts or when spawned
void AElfSelenaCharacterBase::BeginPlay()
{
	Super::BeginPlay();
	
}

// Called every frame
void AElfSelenaCharacterBase::Tick(float DeltaTime)
{
	Super::Tick(DeltaTime);

}

// Called to bind functionality to input
void AElfSelenaCharacterBase::SetupPlayerInputComponent(UInputComponent* PlayerInputComponent)
{
	Super::SetupPlayerInputComponent(PlayerInputComponent);

}

