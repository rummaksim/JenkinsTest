pipeline {
  agent {
    node {
      label 'linux'
    }

  }
  stages {
    stage('Log dotnet version') {
      steps {
        sh 'dotnet --version'
      }
    }

    stage('Build with .NET') {
      steps {
        sh 'dotnet build'
      }
    }

  }
}