FROM amazonlinux
RUN yum update -y
RUN yum groupinstall "Development Tools" -y
RUN rpm -Uvh https://packages.microsoft.com/config/centos/7/packages-microsoft-prod.rpm
RUN yum install -y \
    dotnet-sdk-3.1 \
    aspnetcore-runtime-3.1 \
    dotnet-runtime-3.1 
RUN adduser vscode 
RUN usermod -aG wheel vscode
USER vscode
# Install AWS Tools for dotnet.
RUN dotnet tool install -g Amazon.Lambda.Tools
ENV PATH="${PATH}:~/.dotnet/tools"
