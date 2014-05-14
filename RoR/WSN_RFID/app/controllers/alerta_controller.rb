class AlertaController < ApplicationController
  before_action :set_alertum, only: [:show, :edit, :update, :destroy]

  # GET /alerta
  # GET /alerta.json
  def index
    @alerta = Alertum.all
  end

  # GET /alerta/1
  # GET /alerta/1.json
  def show
  end

  # GET /alerta/new
  def new
    @alertum = Alertum.new
  end

  # GET /alerta/1/edit
  def edit
  end

  # POST /alerta
  # POST /alerta.json
  def create
    @alertum = Alertum.new(alertum_params)

    respond_to do |format|
      if @alertum.save
        format.html { redirect_to @alertum, notice: 'Alertum was successfully created.' }
        format.json { render :show, status: :created, location: @alertum }
      else
        format.html { render :new }
        format.json { render json: @alertum.errors, status: :unprocessable_entity }
      end
    end
  end

  # PATCH/PUT /alerta/1
  # PATCH/PUT /alerta/1.json
  def update
    respond_to do |format|
      if @alertum.update(alertum_params)
        format.html { redirect_to @alertum, notice: 'Alertum was successfully updated.' }
        format.json { render :show, status: :ok, location: @alertum }
      else
        format.html { render :edit }
        format.json { render json: @alertum.errors, status: :unprocessable_entity }
      end
    end
  end

  # DELETE /alerta/1
  # DELETE /alerta/1.json
  def destroy
    @alertum.destroy
    respond_to do |format|
      format.html { redirect_to alerta_url, notice: 'Alertum was successfully destroyed.' }
      format.json { head :no_content }
    end
  end

  private
    # Use callbacks to share common setup or constraints between actions.
    def set_alertum
      @alertum = Alertum.find(params[:id])
    end

    # Never trust parameters from the scary internet, only allow the white list through.
    def alertum_params
      params.require(:alertum).permit(:desconectada)
    end
end
