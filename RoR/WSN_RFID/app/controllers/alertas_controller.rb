class AlertasController < ApplicationController
  before_action :set_alerta, only: [:show, :edit, :update, :destroy]

  before_filter :authorize_alerta

  # GET /alertas
  # GET /alertas.json
  def index
    @alertas = Alerta.all
  end

  # GET /alertas/1
  # GET /alertas/1.json
  def show
  end

  # GET /alertas/new
  def new
    @alerta = Alerta.new
  end

  # GET /alertas/1/edit
  def edit
  end

  # POST /alertas
  # POST /alertas.json
  def create
    @alerta = Alerta.new(alerta_params)

    respond_to do |format|
      if @alerta.save
        @alerta.pushAlert
        format.html { redirect_to @alerta, notice: 'Alerta was successfully created.' }
        format.json { render :show, status: :created, location: @alerta }
      else
        format.html { render :new }
        format.json { render json: @alerta.errors, status: :unprocessable_entity }
      end
    end
  end

  # PATCH/PUT /alertas/1
  # PATCH/PUT /alertas/1.json
  def update
    respond_to do |format|
      if @alerta.update(alerta_params)
        format.html { redirect_to @alerta, notice: 'Alerta was successfully updated.' }
        format.json { render :show, status: :ok, location: @alerta }
      else
        format.html { render :edit }
        format.json { render json: @alerta.errors, status: :unprocessable_entity }
      end
    end
  end

  # DELETE /alertas/1
  # DELETE /alertas/1.json
  def destroy
    @alerta.destroy
    respond_to do |format|
      format.html { redirect_to alertas_url, notice: 'Alerta was successfully destroyed.' }
      format.json { head :no_content }
    end
  end

  private
    # Use callbacks to share common setup or constraints between actions.
    def set_alerta
      @alerta = Alerta.find(params[:id])
    end

    # Never trust parameters from the scary internet, only allow the white list through.
    def alerta_params
      params.require(:alerta).permit(:desconectada)
    end
end
