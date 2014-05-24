class SessionsController < ApplicationController

  skip_before_filter :require_login

  def new
  end

  def create
  	if u = Usuario.authenticate(params[:session][:email], params[:session][:password])
      session[:user_id] = u.id
      redirect_to root_path
    else
      flash.now.alert = "Correo o contraseña incorrecta."
      render :new
    end
  end

  def destroy
  	 reset_session
     flash.notice = "¡Sesión terminada!"
     redirect_to root_path
  end
end
